﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_maximCard : DiceCardSelfAbilityBase
{
	private int killCnt;

	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterGiveDamage(int damage, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_maximCard()
	{
		throw null;
	}
}
