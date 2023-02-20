using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1005311 : PassiveAbilityBase
{
	private readonly List<int> _cardListOne;

	private readonly List<int> _cardListTwo;

	private const int _LYING_DETECTION_CARD_ID = 9910301;

	private const int _REMOVING_ERROR_CARD_ID = 9910303;

	private const int _ANGELA_LIBRARIAN_BOOK_ID = 9100501;

	private int _elapsed;

	private PassiveAbility_1005311.Phase _phase;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleDiceCardModel AddNewCard(int cardId, int priorityAdder, int costAdder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndLyingPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveLyingDetectionCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapFilter(string str)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1005311()
	{
		throw null;
	}

	public enum Phase
	{
		NORMAL,
		LYING
	}
}
