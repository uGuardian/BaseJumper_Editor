using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TeddyMapManager : CreatureMapManager
{
	[SerializeField]
	private AnimationCurve blurFilterCurve;

	private bool _bDoneParrying;

	private bool _bSucceedHug;

	private int _doneParryingDlgCount;

	private int _doneSucceedHugDlgCount;

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
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoneParrying(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SucceedHug()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HugRoutine(CameraFilterPack_Blur_Blurry r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TeddyMapManager()
	{
		throw null;
	}
}
