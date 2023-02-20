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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatterNormal()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternDaze()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternExistingDaze()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardPatternAreaAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id, int priorityAdder)
	{
		
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
