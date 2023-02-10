using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Freischutz_2ndBullet : FarAreaEffect
{
	public AudioClip sound;

	[SerializeField]
	private DiceAttackEffect_EGO_Freischutz_NormalFarAtk upperLine;

	[SerializeField]
	private DiceAttackEffect_EGO_Freischutz_NormalFarAtk lowerLine;

	[SerializeField]
	private float _animSpeed;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _doneTime;

	[SerializeField]
	private Direction _upperBulletDirection;

	[SerializeField]
	private Direction _lowerBulletDirection;

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
	public FarAreaEffect_EGO_Freischutz_2ndBullet()
	{
		throw null;
	}
}
