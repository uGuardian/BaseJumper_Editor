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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCardSlots(int slotSize)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ArrangeCardOrder()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCard(int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardWithoutCurrentAction(int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardByIdx(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyCardAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(BattleDiceCardModel card, BattleUnitModel target, int targetSlot, bool isEnemyAuto = false)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoverPointDefault()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoverPoint(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetPlayPoint()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseWhenStartRound(int playPoint)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayPoint(int value)
	{
		
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
