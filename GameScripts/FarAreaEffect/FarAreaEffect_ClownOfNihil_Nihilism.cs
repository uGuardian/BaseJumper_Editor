using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_ClownOfNihil_Nihilism : FarAreaEffect
{
	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private AnimationCurve _darkenCurve;

	[SerializeField]
	private float _curveSpeed;

	private CameraFilterPack_Colors_DarkColor _filter;

	private float _elapsedGiveDmg;

	private float _elapsedDestroy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_ClownOfNihil_Nihilism()
	{
		throw null;
	}
}
