using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_dmgUp1thisRound : DiceCardSelfAbilityBase
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
	public DiceCardSelfAbility_dmgUp1thisRound()
	{
		throw null;
	}

	public class DmgUp2thisRoundBuf : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeGiveDamage(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DmgUp2thisRoundBuf()
		{
			throw null;
		}
	}
}
