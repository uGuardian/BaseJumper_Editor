using System;
using System.Runtime.CompilerServices;

public class UnitBattleDataHistory
{
	public int data1;

	public int data2;

	public int damageAtOneRound;

	public int counterDamageAtOneRound;

	public int damageAtOneRoundByDice;

	public int takeDamageAtOneRound;

	public int takeBreakDamageAtOneRound;

	public int parryingWinCount;

	public int parryingLoseCount;

	public int parryingDrawCount;

	public int damageToEnemyAtRound;

	public int costAtOneRound;

	public int healAmount;

	public int healAmountAtRound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitBattleDataHistory()
	{
		throw null;
	}
}
