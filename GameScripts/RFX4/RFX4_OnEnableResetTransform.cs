using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_OnEnableResetTransform : MonoBehaviour
{
	private Transform t;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Vector3 startScale;

	private bool isInitialized;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_OnEnableResetTransform()
	{
		throw null;
	}
}
