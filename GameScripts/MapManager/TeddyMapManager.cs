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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoneParrying(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SucceedHug()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HugRoutine(CameraFilterPack_Blur_Blurry r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TeddyMapManager()
	{
		throw null;
	}
}
