using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Pluto_2 : FarAreaEffect
{
	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private float _atkDelay;

	[SerializeField]
	private float _destroyDelay;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPosition(BattleUnitModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Pluto_2()
	{
		throw null;
	}
}
