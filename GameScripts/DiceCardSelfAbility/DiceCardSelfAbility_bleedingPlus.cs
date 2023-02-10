using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_bleedingPlus : DiceCardSelfAbilityBase
{
	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_bleedingPlus()
	{
		throw null;
	}

	public class BattleUnitBuf_bleedingPlus : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int OnGiveKeywordBufByCard(BattleUnitBuf cardBuf, int stack, BattleUnitModel target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_bleedingPlus()
		{
			throw null;
		}
	}
}
