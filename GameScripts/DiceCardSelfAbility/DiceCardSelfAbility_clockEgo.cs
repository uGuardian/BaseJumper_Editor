using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_clockEgo : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_clockEgo()
	{
		throw null;
	}

	public class BattleUnitBuf_clockSpeedDice : BattleUnitBuf
	{
		public int count;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int SpeedDiceNumAdder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_clockSpeedDice()
		{
			throw null;
		}
	}
}
