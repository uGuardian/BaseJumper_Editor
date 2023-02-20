using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RFX4_TrailRenderer : MonoBehaviour
{
	public float VertexLifeTime;

	public float TrailLifeTime;

	[Range(0.001f, 1f)]
	public float MinVertexDistance;

	public float Gravity;

	public Vector3 Force;

	public float InheritVelocity;

	public float Drag;

	[Range(0.001f, 10f)]
	public float Frequency;

	[Range(0.001f, 10f)]
	public float OffsetSpeed;

	public bool RandomTurbulenceOffset;

	[Range(0.001f, 10f)]
	public float Amplitude;

	public float TurbulenceStrength;

	public AnimationCurve VelocityByDistance;

	public float AproximatedFlyDistance;

	public bool SmoothCurves;

	private LineRenderer lineRenderer;

	private List<Vector3> positions;

	private List<float> currentTimes;

	private List<Vector3> velocities;

	[HideInInspector]
	public float currentLifeTime;

	private Transform t;

	private Vector3 prevPosition;

	private Vector3 startPosition;

	private List<Vector3> controlPoints;

	private int curveCount;

	private const float MinimumSqrDistance = 0.01f;

	private const float DivisionThreshold = -0.99f;

	private const float SmoothCurvesScale = 0.5f;

	private float currentVelocity;

	private float turbulenceRandomOffset;

	private bool isInitialized;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetLastDeletedIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePositionsCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddInterpolatedPositions(Vector3 start, Vector3 end)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemovePositionsBeforeIndex(int lastDeletedIndex)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateForce()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateImpulse()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateVelocity()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InterpolateBezier(List<Vector3> segmentPoints, float scale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Vector3> GetDrawingPoints()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Vector3> FindDrawingPoints(int curveIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector3> pointList, int insertionIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CalculateBezierPoint(int curveIndex, float t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_TrailRenderer()
	{
		throw null;
	}
}
