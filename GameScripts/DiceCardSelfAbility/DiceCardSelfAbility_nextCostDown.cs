﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_nextCostDown : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_nextCostDown()
	{
		throw null;
	}

	public class BattleUnitBuf_costAllDown : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCardCostAdder(BattleDiceCardModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_costAllDown()
		{
			throw null;
		}
	}
}
