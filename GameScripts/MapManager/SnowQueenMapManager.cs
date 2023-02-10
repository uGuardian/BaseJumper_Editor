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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSpecialDlg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PhaseTwo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSaveLibrarian()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilterAlpha(float value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowQueenMapManager()
	{
		throw null;
	}
}
