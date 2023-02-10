using System;
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
	protected override void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RedHoodThrow()
	{
		throw null;
	}
}
