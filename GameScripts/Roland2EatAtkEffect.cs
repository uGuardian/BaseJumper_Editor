using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class Roland2EatAtkEffect : DiceAttackEffect
{
	[SerializeField]
	private AudioClip effectSound;

	[SerializeField]
	private UIAnimationEventHandler animEventHandler;

	[SerializeField]
	private Vector3 rolandAdditionalScale;

	[SerializeField]
	private Vector3 EtcAdditionalScale;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyObject()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2EatAtkEffect()
	{
		throw null;
	}
}
