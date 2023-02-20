using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Mountain_Shout : FarAreaEffect
{
	[SerializeField]
	private float _runningTime;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private AudioClip _sound;

	private float _elapsedBeforeGiveDmg;

	private float _elapsedDestroy;

	private CameraFilterPack_Distortion_Dream2 _filter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DistortionRoutine(CameraFilterPack_Distortion_Dream2 r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Mountain_Shout()
	{
		throw null;
	}
}
