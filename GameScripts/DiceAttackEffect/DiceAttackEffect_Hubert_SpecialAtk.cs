using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_Hubert_SpecialAtk : DiceAttackEffect
{
	[SerializeField]
	private List<AudioClip> _sounds;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSoundEvent(int soundIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Hubert_SpecialAtk()
	{
		throw null;
	}
}
