using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_EGO_Freischutz_NormalFarAtk : DiceAttackEffect
{
	[SerializeField]
	private Transform _bulletRoot;

	[SerializeField]
	private float _bulletSpeed;

	[SerializeField]
	private AudioClip _bulletSound;

	private bool _bFireBullet;

	public Direction bulletDirection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPortalOpenAnimEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_EGO_Freischutz_NormalFarAtk()
	{
		throw null;
	}
}
