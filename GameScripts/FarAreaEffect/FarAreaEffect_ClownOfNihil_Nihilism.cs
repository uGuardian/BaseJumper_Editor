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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_ClownOfNihil_Nihilism()
	{
		throw null;
	}
}
