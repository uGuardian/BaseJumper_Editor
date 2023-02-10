using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_XiaoEgo : DiceAttackEffect
{
	[SerializeField]
	private float defaultScaleFactor;

	[SerializeField]
	private float maxScaleFactor;

	[SerializeField]
	private ActionDetail pivotType;

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
	public DiceAttackEffect_XiaoEgo()
	{
		throw null;
	}
}
