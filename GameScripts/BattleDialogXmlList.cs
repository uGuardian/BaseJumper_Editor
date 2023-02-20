using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BattleDialogXmlList : Singleton<BattleDialogXmlList>
{
	public const string WorkshopDictionaryKey = "Workshop";

	private Dictionary<string, BattleDialogRoot> _dictionary;

	private List<BattleDialogRelationWithBookID> _relationList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, BattleDialogRoot> dictionary, List<BattleDialogRelationWithBookID> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDialogByMod(List<BattleDialogCharacter> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogRoot GetGroupData(string groupID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogCharacter GetCharacterData(string groupID, string characterID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogCharacter GetCharacterData(int bookID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogCharacter GetCharacterData_Mod(string workshopId, int bookID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDialog> GetDialogPresetByType(DialogType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialog GetDialogPresetByType(DialogType type, string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogXmlList()
	{
		throw null;
	}
}
