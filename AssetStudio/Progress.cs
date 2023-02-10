using System;
using BaseJumper.Editor;

namespace AssetStudio
{
    public class Progress : OnUpdateArgs, IBaseJumperProgress
    {
        public IProgress<IOnUpdateArgs> Parent {get; set;}
        public static IProgress<IOnUpdateArgs> Dummy = new Progress<IOnUpdateArgs>();
        private int preValue;
        public bool IsFinished {get; set;}
        public string messagePre;
        public string messageIteration;
        public string messagePost;
        public override string Message {
            get {
                string iteration = messageIteration;
                if (iteration == null) {
                    iteration = ((int)(this.Progress * 100)).ToString() + "%";
                }
                return $"{messagePre}{iteration}{messagePost}";
            }
            set {
                messageIteration = value;
            }
        }
        public Progress() {
            Parent = Dummy;
        }
        public Progress(string title) : this() {
            Title = title;
        }
        public Progress(string title, string messagePre) : this(title) {
            this.messagePre = messagePre;
        }
        public Progress(Progress<IOnUpdateArgs> parent) {
            if (parent != null) {
                Parent = parent;
            } else {
                Parent = Dummy;
            }
        }
        public Progress(Progress<IOnUpdateArgs> parent, string title) : this(parent) {
            Title = title;
        }
        public Progress(Progress<IOnUpdateArgs> parent, string title, string messagePre) : this(parent, title) {
            this.messagePre = messagePre;
        }

        public void Finish() {
            IsFinished = true;
            Report(100);
        }

        public void Report(int current, int total)
        {
            var value = (int)(current * 100f / total);
            Report(value);
        }

        private void Report(int value)
        {
            if (value > preValue)
            {
                preValue = value;
                this.Progress = value / 100f;
                Parent.Report(this);
            }
        }

        public void Update() {
            Logger.Warning("Progress Update Method not implemented yet");
        }
    }
}
