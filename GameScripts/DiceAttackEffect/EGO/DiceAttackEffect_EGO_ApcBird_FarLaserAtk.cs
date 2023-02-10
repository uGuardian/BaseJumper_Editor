using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_EGO_ApcBird_FarLaserAtk : DiceAttackEffect
{
	[SerializeField]
	private GameObject _startObj;

	[SerializeField]
	private GameObject _shootObj;

	[SerializeField]
	private GameObject _endObj;

	[SerializeField]
	private float _startDelay;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private float _shootSpeed;

	private float _elapsedStartDelay;

	private float _elapsedEndDelay;

	private float _shootDistanceRatio;

	private bool _bShoot;

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
	public DiceAttackEffect_EGO_ApcBird_FarLaserAtk()
	{
		throw null;
	}
}
