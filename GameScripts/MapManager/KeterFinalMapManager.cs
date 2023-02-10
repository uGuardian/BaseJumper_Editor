using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeterFinalMapManager : CreatureMapManager
{
	[SerializeField]
	protected float _carmenDlgAlpha;

	[SerializeField]
	protected Color _carmenDlgColor;

	[SerializeField]
	protected float _angelaDlgAlpha;

	[SerializeField]
	protected Color _angelaDlgColor;

	[SerializeField]
	protected Color _angelaDlgUnderlayColor;

	[SerializeField]
	protected int _enemyAngelaId;

	[SerializeField]
	private GameObject _endStageEffectRes;

	protected List<string> _angelaDlgIdList;

	protected CreatureDlgEffectUI _angelaDlgEffect;

	protected int _angelaDlgIdx;

	private KeterFinalMapManager.StageEndEvent _endFunc;

	private float _timeChangeColor;

	private float _elapsedChangeColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetPhaseWinEffect(KeterFinalMapManager.StageEndEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
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
	public virtual void CreateAngelaDialog()
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
	protected virtual void SetDialogueColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeterFinalMapManager()
	{
		throw null;
	}

	public delegate void StageEndEvent(bool win);
}
