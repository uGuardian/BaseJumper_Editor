using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_CameraShake : MonoBehaviour
{
	public AnimationCurve ShakeCurve;

	public float Duration;

	public float Speed;

	public float Magnitude;

	public float DistanceForce;

	public float RotationDamper;

	public bool IsEnabled;

	private bool isPlaying;

	[HideInInspector]
	public bool canUpdate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayShake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Shake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_CameraShake()
	{
		throw null;
	}
}
