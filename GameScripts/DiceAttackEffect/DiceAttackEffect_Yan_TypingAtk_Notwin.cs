using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class DiceAttackEffect_Yan_TypingAtk_Notwin : DiceAttackEffect
{
	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private GameObject _failObject;

	public UIAnimationEventHandler eventHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnFailEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Yan_TypingAtk_Notwin()
	{
		throw null;
	}
}
