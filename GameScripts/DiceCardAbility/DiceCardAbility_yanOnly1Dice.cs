﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_yanOnly1Dice : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_yanOnly1Dice()
	{
		throw null;
	}

	public class BattleUnitBuf_changeToYanDecay : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_changeToYanDecay()
		{
			throw null;
		}
	}
}
