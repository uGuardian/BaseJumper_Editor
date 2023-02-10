using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class Roland2_FarArea_SmokeArea : FarAreaEffect
{
	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private Vector3 additionalScale;

	[SerializeField]
	private Vector2 offset;

	private string _PREFAB_PATH;

	private List<Roland2NormalDamagedEffect> effectList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEffectActive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2_FarArea_SmokeArea()
	{
		throw null;
	}
}
