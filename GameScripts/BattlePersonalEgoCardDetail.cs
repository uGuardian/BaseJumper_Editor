using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattlePersonalEgoCardDetail
{
	private BattleUnitModel _self;

	private List<BattleDiceCardModel> _cardsAll;

	private List<BattleDiceCardModel> _cardInHand;

	private List<BattleDiceCardModel> _cardInUse;

	private List<BattleDiceCardModel> _cardInReserved;

	public BattlePersonalEgoCardDetail(BattleUnitModel self)
	{
		this._self = self;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(int cardId)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(LorId cardId)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoCoolTime(int count)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCard(int cardId)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCard(LorId cardId)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnCardsInUse()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseCard(BattleDiceCardModel card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpendCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnCardToHand(BattleDiceCardModel appliedCard)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsCard(int cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetCardAll()
	{
		throw null;
	}
}
