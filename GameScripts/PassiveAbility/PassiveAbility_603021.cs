﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_603021 : PassiveAbilityBase
{
	private List<PassiveAbility_603021.DamagedInfo> _infoList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_603021()
	{
		throw null;
	}

	public class DamagedInfo
	{
		public BattleUnitModel attacker;

		public int damagedNum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DamagedInfo()
		{
			throw null;
		}
	}
}
