﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_unitePower : DiceCardSelfAbilityBase
{
	public override bool IsUniteCard
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
	public DiceCardSelfAbility_unitePower()
	{
		throw null;
	}

	public class BattleUnitBuf_unitePower : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_unitePower()
		{
			throw null;
		}
	}
}
