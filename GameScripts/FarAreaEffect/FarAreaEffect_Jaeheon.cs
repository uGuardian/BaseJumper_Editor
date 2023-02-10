using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_Jaeheon : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	private ActionDetail _startMotion;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamageEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroyEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Jaeheon()
	{
		throw null;
	}
}
