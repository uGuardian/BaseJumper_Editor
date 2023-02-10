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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2EatAtkEffect()
	{
		throw null;
	}
}
