using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Nikolai_SpecialAtk : DiceAttackEffect
{
	[SerializeField]
	private AudioClip _cutSound;

	[SerializeField]
	private AudioClip _bloodSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_PlaySound(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Nikolai_SpecialAtk()
	{
		throw null;
	}
}
