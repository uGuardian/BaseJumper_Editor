using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_BorderOfDeath : DiceAttackEffect
{
	public AudioClip sound1;

	public AudioClip sound2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_PlaySound(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_BorderOfDeath()
	{
		throw null;
	}
}
