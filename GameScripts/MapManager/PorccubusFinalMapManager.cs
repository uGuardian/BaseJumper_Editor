using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PorccubusFinalMapManager : CreatureMapManager
{
	[SerializeField]
	private Color _dlgColor;

	[SerializeField]
	private float _pleasureSpeed;

	[SerializeField]
	private AnimationCurve _pleasureCurve;

	[SerializeField]
	private SpriteRenderer _pleasureFilterSpr;

	[SerializeField]
	private float _pleasureExplosionSpeed;

	[SerializeField]
	private AnimationCurve _pleasureExplosionCurve;

	[SerializeField]
	private SpriteRenderer _pleasureExplosionFilterSpr;

	[SerializeField]
	private float _specialAtkFilterSpeed;

	[SerializeField]
	private SpriteRenderer _specialAtkFilterSpr;

	private int _specialAtkSuccessCount;

	private float _specialAtkFilterElapsed;

	private Coroutine _pleasureExplosionRoutine;

	private Coroutine _pleasureRoutine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPleasureExplosion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PleasureExplosion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPleasure()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Pleasure()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkFilter(bool ended)
	{
		throw null;
	}

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
	public PorccubusFinalMapManager()
	{
		throw null;
	}
}
