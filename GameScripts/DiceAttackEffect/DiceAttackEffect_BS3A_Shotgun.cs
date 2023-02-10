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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayer(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_BS3A_Shotgun()
	{
		throw null;
	}
}
