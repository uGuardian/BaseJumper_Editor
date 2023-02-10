using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Kali_SpecialVert : DiceAttackEffect
{
	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private AudioClip _clip;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayer(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Kali_SpecialVert()
	{
		throw null;
	}
}
