using System;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_XML;

public class DialogData
{
	public BattleDialog xmlData;

	public string customText;

	public string dialogkey;

	private string save_id;

	private string save_content;

	private string save_customtext;

	private string save_key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogData(DialogData other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data, DialogType dialogType)
	{
		throw null;
	}
}
