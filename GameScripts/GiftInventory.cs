using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_DiceSystem;

public class GiftInventory : Savable
{
	public const string save_equipList = "equipList";

	public const string save_unequipList = "unequipList";

	public const string save_offList = "offList";

	private UnitDataModel _owner;

	private List<GiftModel> _equippedList;

	private List<GiftModel> _unequippedList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftInventory(UnitDataModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftModel AddGift(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddGift(GiftModel gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AlreadyGained(GiftModel gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AlreadyGained(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AlreadyGained(GiftXmlInfo gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> GetEquippedList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> GetUnequippedList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> GetGifts()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> GetAllGiftsListForTitle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equip(GiftModel gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UnEquip(GiftModel gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnEquipAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_Hp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_Break()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_BreakRecover()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_Tune()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_Amp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatBonus_Dmg(BehaviourDetail type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		throw null;
	}
}
