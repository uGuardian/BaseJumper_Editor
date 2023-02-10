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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Oswald1st_FireRing()
	{
		throw null;
	}
}
