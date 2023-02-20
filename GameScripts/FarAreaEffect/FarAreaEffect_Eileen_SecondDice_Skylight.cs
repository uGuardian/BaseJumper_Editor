using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_Eileen_SecondDice_Skylight : FarAreaEffect
{
	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private GameObject effect_particle;

	[SerializeField]
	private SpriteRenderer spriterenderer_dummy;

	private float effecttime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
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
	private void OnLightStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroyEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Eileen_SecondDice_Skylight()
	{
		throw null;
	}
}
