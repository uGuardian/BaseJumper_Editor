using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_DiceSystem;

public class DeckModel
{
	public const int maxDeckCount = 9;

	private List<DiceCardXmlInfo> _deck;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ShallowCopy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeckModel Copy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeck(LorId deckId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetAllCardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetCardList_nocopy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCardForLoading(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardEquipState AddCardFromInventory(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllErrorCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCardToInventory(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDeckEmpty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmptyDeckToInventory()
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
	public DeckModel()
	{
		throw null;
	}
}
