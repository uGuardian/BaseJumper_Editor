using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_ScaleCurves : MonoBehaviour
{
	public AnimationCurve FloatCurve;

	public float GraphTimeMultiplier;

	public float GraphIntensityMultiplier;

	public bool IsLoop;

	private bool canUpdate;

	private float startTime;

	private Transform t;

	private int nameId;

	private Projector proj;

	private Vector3 startScale;

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
	public RFX4_ScaleCurves()
	{
		throw null;
	}
}
