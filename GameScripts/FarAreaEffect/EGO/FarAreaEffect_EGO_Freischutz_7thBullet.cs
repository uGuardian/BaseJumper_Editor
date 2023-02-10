using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Freischutz_7thBullet : FarAreaEffect
{
	[SerializeField]
	private SpriteRenderer _bulletSpriteRenderer;

	[SerializeField]
	private float _bulletSpeed;

	[SerializeField]
	private AudioClip _bulletSound;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _waitTime;

	private float _elapsedWait;

	private float _elapsed;

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
	public FarAreaEffect_EGO_Freischutz_7thBullet()
	{
		throw null;
	}
}
