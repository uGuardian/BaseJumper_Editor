﻿using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Binah_Blade : DiceAttackEffect
{
	[SerializeField]
	private float _startDelay;

	[SerializeField]
	private float _moveSpeed;

	private float _elapsedDelay;

	private float _elapsedMove;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Binah_Blade()
	{
		throw null;
	}
}
