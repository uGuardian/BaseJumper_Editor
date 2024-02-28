using System;
using System.Collections.Generic;
using GameSave;
using LOR_XML;
using UnityEngine;

public class BattleDialogueModel : Savable
{
	protected BattleDialogCharacter _xmlInfo;

	protected Dictionary<DialogType, List<BattleDialog>> _dlgDictionary;

	protected Dictionary<DialogType, List<BattleDialog>> _equippedDlgDictionary;

	protected Dictionary<DialogType, DialogData> _data;

	private string save_dlglist = "save_dlglist";

	public Dictionary<DialogType, DialogData> Data
	{
		get
		{
			return this._data;
		}
	}

	public BattleDialogueModel(BattleDialogCharacter battleDlg)
	{
		this.Init(battleDlg);
	}

	public void Init(BattleDialogCharacter battleDlg)
	{
		this._xmlInfo = battleDlg;
		this._dlgDictionary = new Dictionary<DialogType, List<BattleDialog>>();
		this._equippedDlgDictionary = new Dictionary<DialogType, List<BattleDialog>>();
		this._data = new Dictionary<DialogType, DialogData>();
		foreach (BattleDialogType battleDialogType in this._xmlInfo.dialogTypeList)
		{
			if (battleDialogType.dialogType != DialogType.ERROR)
			{
				this._dlgDictionary.Add(battleDialogType.dialogType, battleDialogType.dialogList);
			}
		}
		if (battleDlg.characterID == "Librarian")
		{
			this.RandomAll();
		}
	}

	public void SetDialogByDlgAndIndex(DialogType dlgType, BattleDialog dlg, int index = 0)
	{
		if (!this._equippedDlgDictionary.ContainsKey(dlgType))
		{
			List<BattleDialog> list = new List<BattleDialog>();
			list.Add(dlg);
			this._equippedDlgDictionary.Add(dlgType, list);
			return;
		}
		if (this._equippedDlgDictionary.Count < index + 1)
		{
			this._equippedDlgDictionary[dlgType].Add(dlg);
			return;
		}
		this._equippedDlgDictionary[dlgType][index] = dlg;
	}

	public virtual string GetBattleDlg(DialogType dlgType, List<BattleUnitModel> targets)
	{
		return this.GetBattleDlg(dlgType);
	}

	public virtual string GetBattleDlg(DialogType dlgType, string id)
	{
		string result = string.Empty;
		if (this._dlgDictionary.ContainsKey(dlgType))
		{
			BattleDialog battleDialog = this._dlgDictionary[dlgType].Find((BattleDialog x) => x.dialogID == id);
			if (battleDialog != null)
			{
				result = battleDialog.dialogContent;
			}
		}
		return result;
	}

	public virtual string GetBattleDlg(DialogType dlgType)
	{
		if (this.Data.ContainsKey(dlgType) && this._xmlInfo.characterID == "Librarian")
		{
			if (this.Data[dlgType].xmlData != null)
			{
				return this.Data[dlgType].xmlData.dialogContent;
			}
			if (!string.IsNullOrEmpty(this.Data[dlgType].customText))
			{
				return this.Data[dlgType].customText;
			}
		}
		if (this._dlgDictionary.ContainsKey(dlgType))
		{
			List<BattleDialog> list = this._dlgDictionary[dlgType];
			if (list.Count > 0)
			{
				return list[UnityEngine.Random.Range(0, list.Count)].dialogContent;
			}
		}
		return "";
	}

	public virtual string GetBattleDlgSpecialEvent(string dialogID)
	{
		string result = string.Empty;
		if (this._dlgDictionary.ContainsKey(DialogType.SPECIAL_EVENT))
		{
			BattleDialog battleDialog = this._dlgDictionary[DialogType.SPECIAL_EVENT].Find((BattleDialog x) => x.dialogID == dialogID);
			if (battleDialog != null)
			{
				result = battleDialog.dialogContent;
			}
		}
		return result;
	}

	public void Copy(BattleDialogueModel origin)
	{
		this._xmlInfo = origin._xmlInfo;
		this._dlgDictionary = new Dictionary<DialogType, List<BattleDialog>>(origin._dlgDictionary);
		this._data = new Dictionary<DialogType, DialogData>();
		foreach (KeyValuePair<DialogType, DialogData> keyValuePair in origin._data)
		{
			this._data.Add(keyValuePair.Key, new DialogData(keyValuePair.Value));
		}
	}

	public void RandomAll()
	{
		this._equippedDlgDictionary.Clear();
		Dictionary<DialogType, List<BattleDialog>> dlgDictionary = this._dlgDictionary;
		this.SetDialogByRandom(DialogType.START_BATTLE);
		this.SetDialogByRandom(DialogType.BATTLE_VICTORY);
		this.SetDialogByRandom(DialogType.DEATH);
		this.SetDialogByRandom(DialogType.COLLEAGUE_DEATH);
		this.SetDialogByRandom(DialogType.KILLS_OPPONENT);
	}

	public bool Contains(DialogType type, BattleDialog dlg)
	{
		DialogData dialogData = this.GetDialogData(type);
		return dialogData != null && dialogData.xmlData == dlg;
	}

	public BattleDialog GetEquippedDialogByType(DialogType type)
	{
		List<BattleDialog> list;
		if (this._equippedDlgDictionary.TryGetValue(type, out list) && list.Count > 0)
		{
			return list[0];
		}
		return null;
	}

	public void SetDialogByRandom(DialogType dialogType)
	{
		BattleDialogType battleDialogType = this._xmlInfo.dialogTypeList.Find((BattleDialogType x) => x.dialogType == dialogType);
		if (battleDialogType != null)
		{
			this.SetDialogById(dialogType, RandomUtil.SelectOne<BattleDialog>(battleDialogType.dialogList).dialogID);
		}
	}

	public void SetDialogById(DialogType dialogType, string dialogXmlId)
	{
		BattleDialog dialogXmlInfo = this.GetDialogXmlInfo(dialogType, dialogXmlId);
		if (dialogXmlInfo != null)
		{
			DialogData dialogData;
			if (this._data.TryGetValue(dialogType, out dialogData))
			{
				dialogData.xmlData = dialogXmlInfo;
				dialogData.customText = "";
				return;
			}
			DialogData dialogData2 = new DialogData();
			dialogData2.xmlData = dialogXmlInfo;
			dialogData2.customText = "";
			this._data.Add(dialogType, dialogData2);
		}
	}

	public void SetDialog(DialogType dialogType, DialogData dialog)
	{
		DialogData dialogData;
		if (this._data.TryGetValue(dialogType, out dialogData))
		{
			dialogData.xmlData = dialog.xmlData;
			dialogData.customText = dialog.customText;
			return;
		}
		DialogData dialogData2 = new DialogData();
		dialogData2.xmlData = dialog.xmlData;
		dialogData2.customText = dialog.customText;
		this._data.Add(dialogType, dialogData2);
	}

	public void SetDialogByCustom(DialogType dialogType, string str)
	{
		DialogData dialogData;
		if (this._data.TryGetValue(dialogType, out dialogData))
		{
			dialogData.xmlData = null;
			dialogData.customText = str;
			return;
		}
		DialogData dialogData2 = new DialogData();
		dialogData2.xmlData = null;
		dialogData2.customText = str;
		this._data.Add(dialogType, dialogData2);
	}

	public string GetDialogText(DialogType dialogType)
	{
		DialogData dialogData;
		if (!this._data.TryGetValue(dialogType, out dialogData))
		{
			return "";
		}
		if (dialogData.xmlData != null)
		{
			return dialogData.xmlData.dialogContent;
		}
		return dialogData.customText;
	}

	public DialogData GetDialogData(DialogType dialogType)
	{
		DialogData result;
		if (this._data.TryGetValue(dialogType, out result))
		{
			return result;
		}
		return null;
	}

	private BattleDialog GetDialogXmlInfo(DialogType dialogType, string dialogXmlId)
	{
		BattleDialogType battleDialogType = this._xmlInfo.dialogTypeList.Find((BattleDialogType x) => x.dialogType == dialogType);
		if (battleDialogType != null)
		{
			return battleDialogType.dialogList.Find((BattleDialog x) => x.dialogID == dialogXmlId);
		}
		return null;
	}

	public virtual SaveData GetSaveData()
	{
		SaveData saveData = new SaveData();
		SaveData saveData2 = new SaveData();
		foreach (KeyValuePair<DialogType, DialogData> keyValuePair in this._data)
		{
			keyValuePair.Value.dialogkey = keyValuePair.Key.ToString();
			saveData2.AddData(keyValuePair.Key.ToString(), keyValuePair.Value.GetSaveData());
		}
		saveData.AddData(this.save_dlglist, saveData2);
		return saveData;
	}

	public virtual void LoadFromSaveData(SaveData data)
	{
		SaveData data2 = data.GetData(this.save_dlglist);
		this._data = new Dictionary<DialogType, DialogData>();
		List<DialogType> list = new List<DialogType>();
		for (int i = 0; i < 5; i++)
		{
			DialogType dialogType = (DialogType)i;
			SaveData data3 = data2.GetData(dialogType.ToString());
			if (data3 != null)
			{
				DialogData dialogData = new DialogData();
				dialogData.LoadFromSaveData(data3, dialogType);
				this._data.Add(dialogType, dialogData);
			}
			else
			{
				list.Add(dialogType);
			}
		}
		if (list.Count > 0)
		{
			BattleDialogCharacter characterData = Singleton<BattleDialogXmlList>.Instance.GetCharacterData("Librarian", "Librarian");
			this._xmlInfo = characterData;
			foreach (DialogType dialogByRandom in list)
			{
				this.SetDialogByRandom(dialogByRandom);
			}
		}
	}
}
