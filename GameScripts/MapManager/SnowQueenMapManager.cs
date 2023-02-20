using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SnowQueenMapManager : CreatureMapManager
{
	[SerializeReference]
	private SpriteRenderer _filter;

	[SerializeField]
	private List<SpriteRenderer> _changeSprites;

	[SerializeField]
	private MapChangeFilter _mapChangeFilter;

	private const int _defaultDlgNum = 5;

	private const int _defaultDlg2Num = 5;

	private const int _specialDlgNum = 5;

	private CreatureDlgEffectUI _dlgEffect2;

	private bool _phase2;

	private bool _saveLibrarian;

	private bool _specialDlg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSpecialDlg()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PhaseTwo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSaveLibrarian()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilterAlpha(float value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowQueenMapManager()
	{
		throw null;
	}
}
