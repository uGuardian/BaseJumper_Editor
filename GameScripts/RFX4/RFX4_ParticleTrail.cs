using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RFX4_ParticleTrail : MonoBehaviour
{
	public GameObject Target;

	public Vector2 DefaultSizeMultiplayer;

	public float VertexLifeTime;

	public float TrailLifeTime;

	public bool UseShaderMaterial;

	public Material TrailMaterial;

	public bool UseColorOverLifeTime;

	public Gradient ColorOverLifeTime;

	public float ColorLifeTime;

	public bool UseUvAnimation;

	public int TilesX;

	public int TilesY;

	public int FPS;

	public bool IsLoop;

	[Range(0.001f, 1f)]
	public float MinVertexDistance;

	public bool GetVelocityFromParticleSystem;

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

	private Dictionary<int, LineRenderer> dict;

	private ParticleSystem ps;

	private ParticleSystem.Particle[] particles;

	private TrailRenderer[] trails;

	private Color psColor;

	private Transform targetT;

	private int layer;

	private bool isLocalSpace;

	private Transform t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearTrails()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitTrailRenderer(GameObject go)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveEmptyTrails()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_ParticleTrail()
	{
		throw null;
	}
}
