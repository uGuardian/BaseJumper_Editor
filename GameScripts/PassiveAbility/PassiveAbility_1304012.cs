using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1304012 : PassiveAbilityBase
{
	private const int _dogHead1ID = 703411;

	private const int _dogHead2ID = 703412;

	private const int _chickenHead1ID = 703413;

	private const int _chickenHead2ID = 703414;

	private const int _donkeyHead1ID = 703415;

	private const int _donkeyHead2ID = 703416;

	private const int _tendonID = 703421;

	private const int _headNumMax = 3;

	private int _cardCount;

	private List<PassiveAbility_1304012.Phase> availablePhase;

	private PassiveAbility_1304012.Phase currentPhase;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetAddedDiceCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1304012()
	{
		throw null;
	}

	private enum Phase
	{
		DONKEY,
		DOG,
		CHICKEN
	}
}
