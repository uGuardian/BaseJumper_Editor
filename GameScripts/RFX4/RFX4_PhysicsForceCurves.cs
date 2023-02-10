using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_PhysicsForceCurves : MonoBehaviour
{
	public float ForceRadius;

	public float ForceMultiplier;

	public AnimationCurve ForceCurve;

	public ForceMode ForceMode;

	public float GraphTimeMultiplier;

	public float GraphIntensityMultiplier;

	public bool IsLoop;

	public float DestoryDistance;

	public bool UseDistanceScale;

	public AnimationCurve DistanceScaleCurve;

	public bool UseUPVector;

	public AnimationCurve DragCurve;

	public float DragGraphTimeMultiplier;

	public float DragGraphIntensityMultiplier;

	public string AffectedName;

	[HideInInspector]
	public float forceAdditionalMultiplier;

	private bool canUpdate;

	private float startTime;

	private Transform t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_PhysicsForceCurves()
	{
		throw null;
	}
}
