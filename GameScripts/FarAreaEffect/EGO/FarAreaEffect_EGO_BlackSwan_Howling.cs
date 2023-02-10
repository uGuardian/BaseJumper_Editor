using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_BlackSwan_Howling : FarAreaEffect
{
	[SerializeField]
	private AudioClip _howlingSound;

	[SerializeField]
	private AnimationCurve _radialCurve;

	[SerializeField]
	private AnimationCurve _earthQuakeCurve;

	private CameraFilterPack_Blur_Radial _radialFilter;

	private CameraFilterPack_FX_EarthQuake _earthQuakeFilter;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_BlackSwan_Howling()
	{
		throw null;
	}
}
