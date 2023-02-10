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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSpecialReady()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAreaDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAreaEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKillUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillFilterStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Kill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnKillFilterEnd()
	{
		throw null;
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
