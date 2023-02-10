using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Oswald1st_FireRing : DiceAttackEffect
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private AnimationCurve _movingCurve;

	[SerializeField]
	private GameObject _ringObject;

	[SerializeField]
	private GameObject _damagedEffect;

	private float _moveElapsed;

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
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Oswald1st_FireRing()
	{
		throw null;
	}
}
