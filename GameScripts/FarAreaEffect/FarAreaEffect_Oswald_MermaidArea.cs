using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Oswald_MermaidArea : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private float _delayDamage;

	[SerializeField]
	private float _delayDestory;

	private CameraFilterPack_Distortion_Water_Drop _filter;

	private float _elapsedWaveIntensity;

	private float _elapsedDestroy;

	private float _elapsedDamage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFilterWaveInsensity(float value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Oswald_MermaidArea()
	{
		throw null;
	}
}
