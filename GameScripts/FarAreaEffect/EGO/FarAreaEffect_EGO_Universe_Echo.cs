using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Universe_Echo : FarAreaEffect
{
	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _runningTime;

	private float _elapsed;

	private float _elapsedDestroy;

	private CameraFilterPack_Distortion_Dream2 _filter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDestoryTime(float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DistortionRoutine(CameraFilterPack_Distortion_Dream2 r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Universe_Echo()
	{
		throw null;
	}
}
