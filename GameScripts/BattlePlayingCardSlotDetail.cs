using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattlePlayingCardSlotDetail
{
	private BattleUnitModel _self;

	private int _playPoint;

	private int _reservedPlayPoint;

	private int _losePlayPoint;

	private int _nextRoundPlayPoint;

	private const int _startingPlayPoint = 3;

	private int _defaultRecoverPoint;

	private int _recoverPoint;

	public List<BattlePlayingCardDataInUnitModel> cardAry;

	public Queue<BattlePlayingCardDataInUnitModel> cardQueue;

	public BattleKeepedCardDataInUnitModel keepCard;

	public int PlayPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int ReservedPlayPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattlePlayingCardSlotDetail(BattleUnitModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCardAbility()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCardSlots(int slotSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ArrangeCardOrder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCard(int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardWithoutCurrentAction(int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardByIdx(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(BattleDiceCardModel card, BattleUnitModel target, int targetSlot, bool isEnemyAuto = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStartingPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRecoverPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefaultRecoverPoint(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoverPointDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoverPoint(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RecoverPlayPoint(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int LosePlayPoint(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RecoverPlayPointByCard(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNextRoundPlayPoint(int pp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseWhenStartRound(int playPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayPoint(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnApplyCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpendCost(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReserveCost(int value)
	{
		throw null;
	}
}
