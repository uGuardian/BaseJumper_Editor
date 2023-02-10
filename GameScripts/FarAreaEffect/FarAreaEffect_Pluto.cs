using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Pluto : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private float _startDelay;

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
	public FarAreaEffect_Pluto()
	{
		throw null;
	}
}
