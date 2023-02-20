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
	public void DestroyChain()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinDirection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogState(bool isAttacked)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCageDropStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCageDrop()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
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
