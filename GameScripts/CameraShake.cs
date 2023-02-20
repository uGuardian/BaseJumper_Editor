using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public Transform camTransform;

	public static float shakeDuration;

	public static float shakeAmount;

	public float decreaseFactor;

	private Vector3 originalPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraShake()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CameraShake()
	{
		throw null;
	}
}
