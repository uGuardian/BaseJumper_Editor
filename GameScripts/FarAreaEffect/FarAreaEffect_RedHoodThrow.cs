﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_RedHoodThrow : FarAreaEffect
{
	[SerializeField]
	private ParticleSystem _ps;

	[SerializeField]
	private ParticleSystemRenderer _psRenderer;

	[SerializeField]
	private float _startRotationX;

	[SerializeField]
	private float _velocityX;

	[SerializeField]
	private float _rootTransformPosX;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RedHoodThrow()
	{
		throw null;
	}
}
