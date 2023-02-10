using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_BS3A_Basic : DiceAttackEffect
{
	[SerializeField]
	private ActionDetail _atkPivot;

	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private GameObject _atkEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_BS3A_Basic()
	{
		throw null;
	}
}
