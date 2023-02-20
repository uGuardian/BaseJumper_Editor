using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_TheHead_FarAtk2 : DiceAttackEffect
{
	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private ParticleSystem _afterAtkParticle;

	[SerializeField]
	private LineRenderer[] _lineAry;

	[SerializeField]
	private float _createDamageEffectTime;

	private float _elapsedDamaged;

	private BattleUnitView _targetView;

	private bool _bInitDamagedEffect;

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
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_TheHead_FarAtk2()
	{
		throw null;
	}
}
