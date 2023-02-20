using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LatitiaMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _filterSprite_pink;

	[SerializeField]
	private SpriteRenderer _filterSprite_grey;

	private const int _defaultDlgNum = 6;

	private const int _specialDlg1Num = 5;

	private const int _specialDlg2Num = 5;

	private const int _bossDlgNum = 9;

	private float _pinkTime;

	private float _greyTime;

	private LatitiaMapManager.DlgPhase _phase;

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
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPinkFilterOn(float time = 0.5f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGreyFilterOn(float time = 0.5f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDlgPhase(LatitiaMapManager.DlgPhase phase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LatitiaMapManager()
	{
		throw null;
	}

	public enum DlgPhase
	{
		DEFAULT,
		FRIEND,
		ALONE
	}
}
