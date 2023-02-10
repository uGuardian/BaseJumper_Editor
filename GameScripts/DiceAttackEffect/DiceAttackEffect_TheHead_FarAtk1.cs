using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_TheHead_FarAtk1 : DiceAttackEffect
{
	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private ParticleSystem _afterAtkParticle;

	[SerializeField]
	private LineRenderer _line;

	[SerializeField]
	private float _createDamageEffectTime;

	private float _elapsedDamaged;

	private BattleUnitView _targetView;

	private bool _bInitDamagedEffect;

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
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_TheHead_FarAtk1()
	{
		throw null;
	}
}
