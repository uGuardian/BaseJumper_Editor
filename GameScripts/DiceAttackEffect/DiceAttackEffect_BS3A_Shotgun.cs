using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_BS3A_Shotgun : DiceAttackEffect
{
	[SerializeField]
	private SpriteRenderer _damagedEffect;

	[SerializeField]
	private AnimationCurve _damagedEffectFadeCurve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayer(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_BS3A_Shotgun()
	{
		throw null;
	}
}
