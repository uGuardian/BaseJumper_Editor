using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FX_Script_AttackBasic_HanaSpecial : FX_Script_AttackBasic
{
	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundDamage;

	private bool _bDamageSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FX_Script_AttackBasic_HanaSpecial()
	{
		throw null;
	}
}
