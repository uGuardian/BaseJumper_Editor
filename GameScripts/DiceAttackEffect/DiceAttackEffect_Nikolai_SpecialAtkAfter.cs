using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Nikolai_SpecialAtkAfter : DiceAttackEffect
{
	[SerializeField]
	private AudioClip _soundSwordUp;

	[SerializeField]
	private AudioClip _soundSwordDown;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_PlaySound(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Nikolai_SpecialAtkAfter()
	{
		throw null;
	}
}
