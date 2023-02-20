using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PorccubusMapManager : MapManager
{
	[SerializeField]
	private AnimationCurve _pleasureFilterCurve;

	[SerializeField]
	private SpriteRenderer _pleasureFilter;

	[SerializeField]
	private Color _dlgColor;

	private PorccubusMapManager.DlgType _curDlgType;

	private CameraFilterPack_FX_EarthQuake _earthQuakeFilter;

	private float _elapsedChangeDlgState;

	private Dictionary<PorccubusMapManager.DlgType, CreatureBattleDlgInfo> _dlgDictionary;

	private CreatureDlgEffectUI _dlgEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDlgType(PorccubusMapManager.DlgType dlgType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPleasureFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPleasureExplosionFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PleasureExplosionFilterRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PleasureFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDialog(PorccubusMapManager.DlgType dlgType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PorccubusMapManager()
	{
		throw null;
	}

	public enum DlgType
	{
		NORMAL,
		HAPPY
	}
}
