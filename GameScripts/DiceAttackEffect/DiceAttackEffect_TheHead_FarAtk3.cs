using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_TheHead_FarAtk3 : DiceAttackEffect
{
	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private float _createDamageEffectTime;

	private float _elapsedDamaged;

	private BattleUnitView _targetView;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_TheHead_FarAtk3()
	{
		throw null;
	}
}
