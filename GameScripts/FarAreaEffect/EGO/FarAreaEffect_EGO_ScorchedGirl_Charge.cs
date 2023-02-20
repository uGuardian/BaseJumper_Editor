using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ScorchedGirl_Charge : FarAreaEffect
{
	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private SpriteRenderer _bgRenderer;

	[SerializeField]
	private float _atkDelay;

	private float _elapsed;

	private CameraFilterPack_FX_EarthQuake _camFilter;

	private ActionDetail _beforeMotion;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FocusCam(List<BattleUnitModel> targets)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ScorchedGirl_Charge()
	{
		throw null;
	}
}
