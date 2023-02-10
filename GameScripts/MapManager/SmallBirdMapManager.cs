using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SmallBirdMapManager : CreatureMapManager
{
	[SerializeField]
	private GameObject[] _chainObjects;

	[SerializeField]
	private GameObject[] _chainParticles;

	[SerializeField]
	private Animator _animator;

	private const int _defaultDlgNum = 4;

	private const int _specialDlgNum = 2;

	private const float _filterTime = 0.6f;

	private const float _filterSpeed = 80f;

	private const float _filterPower = 0.045f;

	private const int _chainMax = 3;

	private int _chainDestroyed;

	private bool _isAttacked;

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
	public void DestroyChain()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirection()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogState(bool isAttacked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCageDropStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCageDrop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEnd()
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
	public static IEnumerator FilterCoroutine(CameraFilterPack_FX_EarthQuake q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SmallBirdMapManager()
	{
		throw null;
	}
}
