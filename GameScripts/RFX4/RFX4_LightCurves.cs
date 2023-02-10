using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_LightCurves : MonoBehaviour
{
	public AnimationCurve LightCurve;

	public float GraphTimeMultiplier;

	public float GraphIntensityMultiplier;

	public bool IsLoop;

	[HideInInspector]
	public bool canUpdate;

	private float startTime;

	private Light lightSource;

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
	public RFX4_LightCurves()
	{
		throw null;
	}
}
