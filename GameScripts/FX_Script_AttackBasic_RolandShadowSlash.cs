using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FX_Script_AttackBasic_RolandShadowSlash : FX_Script_AttackBasic
{
	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundDamage;

	[SerializeField]
	private AudioClip _soundEnd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSound_Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSound_Damage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSound_End()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_AttackBasic_RolandShadowSlash()
	{
		throw null;
	}
}
