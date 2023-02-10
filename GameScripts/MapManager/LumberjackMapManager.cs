using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LumberjackMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _filterSprite;

	[SerializeField]
	private SpriteRenderer scaryFilter;

	private const int _dlg_P1_num = 5;

	private const int _dlg_P2_num = 4;

	private const int _dlg_SP_num = 4;

	private const float _filterTime = 1f;

	private List<string> _creatureDlgIdList2;

	private CreatureDlgEffectUI _dlgEffect2;

	private bool super;

	private LumberjackMapManager.LumberjackState _state;

	public LumberjackMapManager.LumberjackState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTransform()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSuper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateSpecialDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRecoverBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPhase(LumberjackMapManager.LumberjackState state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SpecialAtkRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LumberjackMapManager()
	{
		throw null;
	}

	public enum LumberjackState
	{
		None,
		Phase_1,
		Phase_2,
		Down
	}
}
