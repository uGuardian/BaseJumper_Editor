﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_breakDmg2thisRoundHit : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_breakDmg2thisRoundHit()
	{
		throw null;
	}

	public class BattleUnitBuf_breakUpHit : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_breakUpHit()
		{
			throw null;
		}
	}
}
