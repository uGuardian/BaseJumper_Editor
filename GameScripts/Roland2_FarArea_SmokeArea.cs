﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class Roland2_FarArea_SmokeArea : FarAreaEffect
{
	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private Vector3 additionalScale;

	[SerializeField]
	private Vector2 offset;

	private string _PREFAB_PATH;

	private List<Roland2NormalDamagedEffect> effectList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEffectActive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2_FarArea_SmokeArea()
	{
		throw null;
	}
}
