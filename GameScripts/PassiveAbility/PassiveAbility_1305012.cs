using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_1305012 : PassiveAbilityBase
{
	private int _dazeReleasedCount;

	private const int _CARD_ID_NORMAL_ATK = 703501;

	private const int _CARD_ID_GUARD = 703502;

	private const int _CARD_ID_EVADE = 703503;

	private const int _CARD_ID_STRONG_ATK = 703504;

	private const int _CARD_ID_FAR_ATK = 703505;

	private const int _CARD_ID_DAZE = 703506;

	private const int _CARD_ID_AREA_ATK = 703507;

	public PassiveAbility_1305012.CardPhase cardPhase;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseDazeReleasedCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatterNormal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternDaze()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternExistingDaze()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternAreaAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id, int priorityAdder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1305012()
	{
		throw null;
	}

	public enum CardPhase
	{
		NORMAL,
		DO_DAZE,
		EXIST_DAZE,
		AREA_ATK
	}
}
