using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class SpecialCardListModel : Singleton<SpecialCardListModel>
{
	private List<BattleDiceCardModel> _cardInHand;

	private List<BattleDiceCardModel> _cardInReserved;

	private List<BattleDiceCardModel> _cardInUse;

	private Dictionary<SephirahType, List<BattleDiceCardModel>> _cardSelectedDataByFloor;

	private Dictionary<SephirahType, List<BattleDiceCardModel>> _cardHandedDataByFloor;

	private List<BattleDiceCardModel> _handEtc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFloorCardData(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistEgoCardBySelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistEgoCardHand(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(LorId cardId, SephirahType floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardCardsInUse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpendCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeEgoCoolTimeState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnCardToHand(BattleUnitModel unit, BattleDiceCardModel appliedCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRunningCoolTimeForEgo(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAddedCoolTimeEgoCard(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoCoolTime(int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAddedEgoCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEgoCoolTime(int unitcount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialCardListModel()
	{
		throw null;
	}
}
