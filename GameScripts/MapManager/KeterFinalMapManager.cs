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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
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
	public virtual void CreateAngelaDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetDialogueColors()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeterFinalMapManager()
	{
		throw null;
	}

	public delegate void StageEndEvent(bool win);
}
