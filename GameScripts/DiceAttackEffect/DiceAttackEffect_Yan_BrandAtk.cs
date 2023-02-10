using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class DiceAttackEffect_Yan_BrandAtk : DiceAttackEffect
{
	[SerializeField]
	private UIAnimationEventHandler _animHandler;

	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundDamage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDamageEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Yan_BrandAtk()
	{
		throw null;
	}
}
