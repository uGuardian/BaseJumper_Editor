using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Freischutz_5thBullet : FarAreaEffect
{
	public AudioClip sound;

	public List<Transform> bullets;

	public float bulletSpeed;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _doneTime;

	private float _elapsed;

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
	public FarAreaEffect_EGO_Freischutz_5thBullet()
	{
		throw null;
	}
}
