using System;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Linq;

namespace BaseJumper.Editor {
	public interface IOnUpdateArgs {
		string Title {get; set;}
		string Message {get; set;}
		float Progress {get; set;}
		IOnUpdateArgs Clone();
		IOnUpdateArgs Clone(float progress);

	}
	public interface IBaseJumperProgress : IOnUpdateArgs {
		bool IsFinished {get; set;}
		void Update();
	}
	public class OnUpdateArgs : EventArgs, IOnUpdateArgs, ICloneable {
		public virtual string Title {get; set;}
		public virtual string Message {get; set;}
		public virtual float Progress {get; set;}
		public OnUpdateArgs() {}
		public OnUpdateArgs(string title, string message) {
			this.Title = title;
			this.Message = message;
		}
		public OnUpdateArgs(string title, string message, float progress) : this(title, message) {
			this.Progress = progress;
		}
		public OnUpdateArgs(OnUpdateArgs args) {
			this.Title = args.Title;
			this.Message = args.Message;
		}
		public OnUpdateArgs(OnUpdateArgs args, float progress) : this(args) {
			this.Progress = progress;
		}
		public IOnUpdateArgs Clone() {
			return new OnUpdateArgs(this);
		}
		object ICloneable.Clone() => Clone();
		public IOnUpdateArgs Clone(float progress) {
			return new OnUpdateArgs(this, progress);
		}
	}

	public class Progress : Progress<IOnUpdateArgs> {
		IBaseJumperProgress currentProgress;
		/*
		public int TotalInstances {
			get {
				return totalInstances;
			}
			set {
				int difference = value - totalInstances;
				totalInstances += difference;
				currentIndex += difference;
			}
		}
		*/
		int totalInstances;
		int currentIndex;
		bool toClear;
		readonly ConcurrentQueue<IBaseJumperProgress> progressInstances = new ConcurrentQueue<IBaseJumperProgress>();
		public Progress(EventHandler<IOnUpdateArgs> displayProgress, Action clearProgress) : base() {
			displayProgressBarAction = displayProgress;
			clearProgressBarAction = clearProgress;
			ProgressChanged += displayProgress;
			ProgressChanged += ClearCheck;
		}
		void ClearCheck(object _, IOnUpdateArgs args) {
			if (toClear) {
				Clear();
				toClear = false;
				clearProgressBarAction();
			}
		}
		public ProgressInstance NewProgress(string title, string message) {
			var progress = new ProgressInstance(this, title, message);
			progressInstances.Enqueue(progress);
			totalInstances++;
			return progress;
		}
		public void AddProgress(IBaseJumperProgress progress) {
			progressInstances.Enqueue(progress);
			totalInstances++;
		}
		public bool TryUpdateProgress(bool autoResetTotals = true) {
			var result = TryUpdateProgress_Internal();
			if (autoResetTotals && !result) {
				totalInstances = 0;
				currentIndex = 0;
			}
			return result;
		}
		bool TryUpdateProgress_Internal() {
			if (currentProgress?.IsFinished ?? true) {
				if (progressInstances.TryDequeue(out currentProgress)) {
					currentIndex++;
					return true;
				}
				return false;
			}
			return true;
		}
		public void Update() {
			if (TryUpdateProgress()) {
				currentProgress.Update();
			}
		}
		public readonly EventHandler<IOnUpdateArgs> displayProgressBarAction;
		public readonly Action clearProgressBarAction;
		protected override void OnReport(IOnUpdateArgs value) {
			if (TryUpdateProgress()) {
				float overallValue = (float)(currentIndex-1) / totalInstances;
				float currentValue = value.Progress / totalInstances;
				float totalValue = overallValue + currentValue;
				var newArgs = value.Clone(totalValue);
				try {
					displayProgressBarAction(this, newArgs);
				} catch {
					base.OnReport(value.Clone(totalValue));
				}
			}
		}
		public void Clear() {
			if (currentProgress != null) {
				currentProgress.IsFinished = true;
				currentProgress = null;
			}
			while (progressInstances.TryDequeue(out var instance)) {
				instance.IsFinished = true;
			}
			totalInstances = 0;
			currentIndex = 0;
			try {
				clearProgressBarAction();
			} catch {
				toClear = true;
				((IProgress<IOnUpdateArgs>)this).Report(new OnUpdateArgs(string.Empty, string.Empty, 1f));
			}
		}
		public class ProgressInstance : OnUpdateArgs, IBaseJumperProgress, IProgress<float>, IProgress<int> {
			readonly IProgress<IBaseJumperProgress> parent;
			public bool IsFinished {get; set;}
			internal ProgressInstance(Progress parent, string title, string message) {
				this.parent = parent;
				Title = title;
				Message = message;
			}
			public void UpdateStrings() {
				if (TitleGetter != null) {
					Delegate[] dels = TitleGetter.GetInvocationList();
					for (int i = 0; i < dels.Length; i++) {
						try {
							Func<string> del = (Func<string>)dels[i];
							Message = del();
						} catch (Exception ex) {
							Debug.LogException(ex);
						}
					}
				}
				if (MessageGetter != null) {
					Delegate[] dels = MessageGetter.GetInvocationList();
					for (int i = 0; i < dels.Length; i++) {
						try {
							Func<string> del = (Func<string>)dels[i];
							Message = del();
						} catch (Exception ex) {
							Debug.LogException(ex);
						}
					}
				}
			}
			public void Update() {
				UpdateStrings();
				if (ProgressGetter != null) {
					/*
					float result = ValueGetter
						.GetInvocationList()
						.Cast<Func<float, float>>()
						.Aggregate(-1f, (current, del) => del(current));
					*/
					float result = -1;
					Delegate[] dels = ProgressGetter.GetInvocationList();
					for (int i = 0; i < dels.Length; i++) {
						try {
							Func<float, float> del = (Func<float, float>)dels[i];
							result = del(result);
						} catch (Exception ex) {
							Debug.LogException(ex);
						}
					}
					result = Mathf.Clamp(result, 0, 1);
					Report(result);
				}
				if (CompletionGetter != null) {
					Delegate[] dels = CompletionGetter.GetInvocationList();
					for (int i = 0; i < dels.Length; i++) {
						try {
							Func<bool> del = (Func<bool>)dels[i];
							if (del()) {
								IsFinished = true;
							}
						} catch (Exception ex) {
							Debug.LogException(ex);
						}
					}
					if (IsFinished) {
						Finish();
					}
				}
			}
			public void Report(int value) {
				((IProgress<float>)this).Report(value/100f);
			}
			public void Report(float value) {
				UpdateStrings();
				Progress = value;
				parent.Report(this);
			}
			public void Finish() {
				IsFinished = true;
				Report(1f);
			}
			public event Func<float, float> ProgressGetter;
			public event Func<bool> CompletionGetter;
			public event Func<string> TitleGetter;
			public event Func<string> MessageGetter;
		}
	}
}