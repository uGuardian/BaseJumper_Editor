﻿using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_KoDFatalSwordFarAtk : DiceAttackEffect
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private AnimationCurve _movingCurve;

	[SerializeField]
	private GameObject _movingEffect;

	[SerializeField]
	private GameObject _damagedEffect;

	private float _moveElapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_KoDFatalSwordFarAtk()
	{
		throw null;
	}
}
