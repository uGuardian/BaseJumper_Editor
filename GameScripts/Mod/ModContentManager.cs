using System;
using System.Collections.Generic;
using System.IO;
using GameSave;
using UnityEngine;

namespace Mod
{
	public class ModContentManager : Singleton<ModContentManager>
	{
		public const string save_orders = "orders";

		public const string save_lastActivated = "lastActivated";

		private List<ModContent> _loadedContents = new List<ModContent>();

		private List<ModContentInfo> _allMods = new List<ModContentInfo>();

		private List<string> _logs = new List<string>();

		private string _currentPid = "";

		private string savePath
		{
			get
			{
				return Path.Combine(SaveManager.savePath, "ModSetting.save");
			}
		}

		public void InitModInfos()
		{
			this._allMods = new List<ModContentInfo>();
			List<ModContentInfo> collection = ModContentInfoLoader.LoadAllModInfos();
			this._allMods.AddRange(collection);
			this.LoadSelectionData();
		}

		public List<ModContentInfo> GetAllMods()
		{
			return this._allMods;
		}

		public string GetModPath(string packageId)
		{
			ModContentInfo modContentInfo = this._allMods.Find((ModContentInfo x) => x.invInfo.workshopInfo.uniqueId == packageId);
			if (modContentInfo == null)
			{
				return "";
			}
			return modContentInfo.dirInfo.FullName;
		}

		public string GetStoryStandingDirPath(string packageId)
		{
			return Path.Combine(this.GetModPath(packageId), "Resource", "StoryStanding");
		}

		public string GetStoryStoryCgDirPath(string packageId)
		{
			return Path.Combine(this.GetModPath(packageId), "Resource", "StoryCg");
		}

		public string GetStoryStoryBgmDirPath(string packageId)
		{
			return Path.Combine(this.GetModPath(packageId), "Resource", "StoryBgm");
		}

		public void SetActiveContents(List<ModContentInfo> targets)
		{
			foreach (ModContentInfo modContentInfo in this._allMods)
			{
				modContentInfo.activated = false;
			}
			List<ModContentInfo> list = new List<ModContentInfo>();
			using (List<ModContentInfo>.Enumerator enumerator = targets.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ModContentInfo mod = enumerator.Current;
					this._currentPid = mod.invInfo.workshopInfo.uniqueId;
					if (list.Exists((ModContentInfo x) => x.invInfo.workshopInfo.uniqueId == mod.invInfo.workshopInfo.uniqueId))
					{
						this.AddErrorLog("The same Mod ID already exists. This mod was ignored.");
					}
					else
					{
						ModContent modContent = ModContent.LoadModContent(mod);
						if (modContent != null)
						{
							this._loadedContents.Add(modContent);
							list.Add(mod);
						}
						this._currentPid = "";
					}
				}
			}
			Singleton<AssemblyManager>.Instance.CallAllInitializer();
			this.SaveSelectionData(this._allMods, list);
		}

		public void AddErrorLog(string msg)
		{
			Debug.LogError(msg);
			if (!string.IsNullOrEmpty(this._currentPid))
			{
				this._logs.Add("(pid: " + this._currentPid + ")" + msg);
				return;
			}
			this._logs.Add(msg);
		}

		public void AddWarningLog(string msg)
		{
			Debug.LogError(msg);
			if (!string.IsNullOrEmpty(this._currentPid))
			{
				this._logs.Add(string.Concat(new string[]
				{
					"<color=yellow>(pid: ",
					this._currentPid,
					")",
					msg,
					"</color>"
				}));
				return;
			}
			this._logs.Add(msg);
		}

		public void AddErrorLog(string msg, Exception e)
		{
			Debug.LogError(e);
			if (!string.IsNullOrEmpty(this._currentPid))
			{
				this._logs.Add(string.Concat(new string[]
				{
					" Error :(pid: ",
					this._currentPid,
					"),(",
					msg,
					")",
					e.Message
				}));
				return;
			}
			this._logs.Add(e.Message);
		}

		public void AddErrorLog(Exception e)
		{
			Debug.LogError(e);
			if (!string.IsNullOrEmpty(this._currentPid))
			{
				this._logs.Add("(pid: " + this._currentPid + ")" + e.Message);
				return;
			}
			this._logs.Add(e.Message);
		}

		public List<string> GetErrorLogs()
		{
			return this._logs;
		}

		public void SaveSelectionData(List<ModContentInfo> allMods, List<ModContentInfo> activateds)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			foreach (ModContentInfo modContentInfo in allMods)
			{
				list.Add(modContentInfo.invInfo.workshopInfo.uniqueId);
			}
			foreach (ModContentInfo modContentInfo2 in activateds)
			{
				list2.Add(modContentInfo2.invInfo.workshopInfo.uniqueId);
			}
			SaveData saveData = new SaveData();
			SaveData saveData2 = new SaveData(SaveDataType.List);
			SaveData saveData3 = new SaveData(SaveDataType.List);
			foreach (string value in list)
			{
				saveData2.AddToList(new SaveData(value));
			}
			foreach (string value2 in list2)
			{
				saveData3.AddToList(new SaveData(value2));
			}
			saveData.AddData("orders", saveData2);
			saveData.AddData("lastActivated", saveData3);
			Singleton<SaveManager>.Instance.SaveData(this.savePath, saveData);
		}

		public void LoadSelectionData()
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			SaveData saveData = Singleton<SaveManager>.Instance.LoadData(this.savePath);
			if (saveData == null)
			{
				return;
			}
			SaveData data = saveData.GetData("orders");
			SaveData data2 = saveData.GetData("lastActivated");
			if (data != null)
			{
				foreach (SaveData saveData2 in data)
				{
					string stringSelf = saveData2.GetStringSelf();
					if (!string.IsNullOrEmpty(stringSelf))
					{
						list.Add(stringSelf);
					}
				}
			}
			if (data2 != null)
			{
				foreach (SaveData saveData3 in data2)
				{
					string stringSelf2 = saveData3.GetStringSelf();
					if (!string.IsNullOrEmpty(stringSelf2))
					{
						list2.Add(stringSelf2);
					}
				}
			}
			List<ModContentInfo> list3 = new List<ModContentInfo>(this._allMods);
			this._allMods.Clear();
			using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					string id = enumerator2.Current;
					ModContentInfo modContentInfo = list3.Find((ModContentInfo x) => x.invInfo.workshopInfo.uniqueId == id);
					if (modContentInfo != null)
					{
						list3.Remove(modContentInfo);
						this._allMods.Add(modContentInfo);
					}
				}
			}
			this._allMods.AddRange(list3);
			using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					string id = enumerator2.Current;
					ModContentInfo modContentInfo2 = this._allMods.Find((ModContentInfo x) => x.invInfo.workshopInfo.uniqueId == id);
					if (modContentInfo2 != null)
					{
						modContentInfo2.activated = true;
					}
				}
			}
		}
	}
}
