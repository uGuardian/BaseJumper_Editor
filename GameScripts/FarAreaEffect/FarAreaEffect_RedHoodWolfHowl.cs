using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_RedHoodWolfHowl : FarAreaEffect
{
	[SerializeField]
	private float _earthQuakeOffset;

	[SerializeField]
	private float _earthQuakeSpeed;

	[SerializeField]
	private CameraFilterPack_Distortion_Water_Drop _waterDropFilter;

	[SerializeField]
	private CameraFilterPack_FX_EarthQuake _earthquakeFilter;

	private float e;

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
	public override void OnAnimSoundEvent(int i)
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
	public FarAreaEffect_RedHoodWolfHowl()
	{
		throw null;
	}
}
