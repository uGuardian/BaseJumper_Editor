﻿using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Oswald1st_Daze : DiceAttackEffect
{
	[SerializeField]
	private AudioClip _dazeSound;

	[SerializeField]
	private float _lensDestroyTime;

	private DirtyLensFlare _lensFlare;

	[SerializeField]
	private AnimationCurve _dirtyLensCurve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Oswald1st_Daze()
	{
		throw null;
	}
}
