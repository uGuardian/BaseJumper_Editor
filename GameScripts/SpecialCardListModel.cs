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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFloorCardData(SephirahType sep)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardCardsInUse()
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
	public void ChangeEgoCoolTimeState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnCardToHand(BattleUnitModel unit, BattleDiceCardModel appliedCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRunningCoolTimeForEgo(bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAddedCoolTimeEgoCard(SephirahType sep)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoCoolTime(int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAddedEgoCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEgoCoolTime(int unitcount)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialCardListModel()
	{
		throw null;
	}
}
