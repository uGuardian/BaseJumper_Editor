using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class InventoryModel : Singleton<InventoryModel>, Savable
{
	public const string save_cardList = "cardList";

	private List<DiceCardItemModel> _cardList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(int cardId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(LorId cardId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllErrorCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveCard(LorId cardId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateEmptyItem(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardItemModel> GetCardListOrigin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardItemModel> GetCardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardCount(int cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardCount(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardTypeCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsCard(int cardId)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryModel()
	{
		throw null;
	}
}
