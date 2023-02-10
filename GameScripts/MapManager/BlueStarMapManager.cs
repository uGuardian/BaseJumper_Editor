using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlueStarMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject _defaultSprite;

	[SerializeField]
	private GameObject _specialSprite;

	[SerializeField]
	private GameObject _particle;

	public Transform Root;

	private const int _defaultDlgNum = 3;

	private const int _specialDlgNum = 3;

	private BlueStarMapManager.BlueStarState _state;

	private List<int> coolTimes;

	public BlueStarMapManager.BlueStarState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSpecialReady()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAreaDmg()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAreaEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKillUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillFilterStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Kill()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnKillFilterEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator KillFilterCoroutine(CameraFilterPack_Distortion_Twist f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BlueStarMapManager()
	{
		throw null;
	}

	public enum BlueStarState
	{
		Default,
		Special
	}
}
