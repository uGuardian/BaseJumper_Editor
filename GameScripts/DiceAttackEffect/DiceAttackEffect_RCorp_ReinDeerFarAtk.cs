using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_RCorp_ReinDeerFarAtk : DiceAttackEffect
{
	[SerializeField]
	private LineRenderer _line;

	[SerializeField]
	private RCorp_RudolphBezier _bezier;

	[SerializeField]
	private AnimationCurve _widthCurve;

	[SerializeField]
	private GameObject _targetParticle;

	[SerializeField]
	private GameObject _selfParticle;

	private Vector3[] _stdPosAry;

	private float _resetTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_RCorp_ReinDeerFarAtk()
	{
		throw null;
	}
}
