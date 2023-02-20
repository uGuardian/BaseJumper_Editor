using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Wizard_Special : FarAreaEffect
{
	[SerializeField]
	private AudioClip _soundCollision;

	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundExplosion;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAnimEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAnimSoundEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Wizard_Special()
	{
		throw null;
	}
}
