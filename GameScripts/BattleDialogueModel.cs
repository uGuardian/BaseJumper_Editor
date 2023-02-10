using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_XML;

public class BattleDialogueModel : Savable
{
	protected BattleDialogCharacter _xmlInfo;

	protected Dictionary<DialogType, List<BattleDialog>> _dlgDictionary;

	protected Dictionary<DialogType, List<BattleDialog>> _equippedDlgDictionary;

	protected Dictionary<DialogType, DialogData> _data;

	private string save_dlglist;

	public Dictionary<DialogType, DialogData> Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogueModel(BattleDialogCharacter battleDlg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleDialogCharacter battleDlg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogByDlgAndIndex(DialogType dlgType, BattleDialog dlg, int index = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg(DialogType dlgType, List<BattleUnitModel> targets)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg(DialogType dlgType, string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg(DialogType dlgType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlgSpecialEvent(string dialogID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Copy(BattleDialogueModel origin)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RandomAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(DialogType type, BattleDialog dlg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialog GetEquippedDialogByType(DialogType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogByRandom(DialogType dialogType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogById(DialogType dialogType, string dialogXmlId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialog(DialogType dialogType, DialogData dialog)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogByCustom(DialogType dialogType, string str)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDialogText(DialogType dialogType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogData GetDialogData(DialogType dialogType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleDialog GetDialogXmlInfo(DialogType dialogType, string dialogXmlId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadFromSaveData(SaveData data)
	{
		throw null;
	}
}
