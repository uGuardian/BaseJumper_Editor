using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class FX_Script_AttackBasic : DiceAttackEffect
{
	public UIAnimationEventHandler eventHandler;

	public GameObject _UnATKFX;

	public ActionDetail action;

	public bool unAtkRandom;

	[SerializeField]
	private AudioClip _DamageSound;

	[SerializeField]
	private Vector3 _localEulerAngle;

	private BattleUnitView _target;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSoundEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_AttackBasic()
	{
		throw null;
	}
}
