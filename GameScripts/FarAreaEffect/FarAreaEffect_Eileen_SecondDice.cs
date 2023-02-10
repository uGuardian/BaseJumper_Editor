using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_Eileen_SecondDice : FarAreaEffect
{
	[SerializeField]
	private UIAnimationEventHandler _handler;

	protected Vector3 additionalScale;

	[SerializeField]
	private Vector2 offset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStartEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamageEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroyEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Eileen_SecondDice()
	{
		throw null;
	}
}
