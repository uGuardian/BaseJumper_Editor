using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BigBadWolfMapManager : CreatureMapManager
{
	[SerializeField]
	private List<SpriteRenderer> _redSprites;

	[SerializeField]
	private SpriteRenderer _transFilter;

	[SerializeField]
	private AnimationCurve _transFilterCurve;

	[SerializeField]
	private FarAreaEffect _howlingEffect;

	[SerializeField]
	private SpriteRenderer _eatFilterRoot;

	[SerializeField]
	private SpriteRenderer _spitFilterRoot;

	[SerializeField]
	private SpriteRenderer[] _eatFilters;

	[SerializeField]
	private SpriteRenderer[] _spitFilters;

	[SerializeField]
	private SpriteRenderer _stealthFilter;

	[SerializeField]
	private SpriteRenderer _stealthDoneFilter;

	[SerializeField]
	private SpriteRenderer _willEatFilter;

	[SerializeField]
	private SpriteRenderer _eatenFilter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPolymorphEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEatFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpitFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEatenFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWillEatFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDoneStealthFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DoneStealthRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStealthFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EatFilterRoutine(SpriteRenderer filter1, SpriteRenderer filter2, bool runningEffect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHowlingFilter(BattleUnitModel actor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect GetHowlingEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PolymorphRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
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
	private void ResetValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BigBadWolfMapManager()
	{
		throw null;
	}
}
