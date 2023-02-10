using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class FX_Script_AttackBasic_T : DiceAttackEffect
{
	public UIAnimationEventHandler eventHandler;

	public GameObject _UnATKFX;

	[SerializeField]
	private AudioClip _DamageSound;

	private BattleUnitView _target;

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
	private void OnSoundEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_AttackBasic_T()
	{
		throw null;
	}
}
