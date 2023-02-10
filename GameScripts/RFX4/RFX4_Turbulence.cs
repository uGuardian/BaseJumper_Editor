using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class RFX4_Turbulence : MonoBehaviour
{
	public float TurbulenceStrenght;

	public bool TurbulenceByTime;

	public float TimeDelay;

	public AnimationCurve TurbulenceStrengthByTime;

	public Vector3 Frequency;

	public Vector3 OffsetSpeed;

	public Vector3 Amplitude;

	public Vector3 GlobalForce;

	public bool UseGlobalOffset;

	public RFX4_Turbulence.MoveMethodEnum MoveMethod;

	public RFX4_Turbulence.PerfomanceEnum Perfomance;

	public float ThreshholdSpeed;

	public AnimationCurve VelocityByDistance;

	public float AproximatedFlyDistance;

	private float lastStopTime;

	private Vector3 currentOffset;

	private float deltaTime;

	private float deltaTimeLastUpdateOffset;

	private ParticleSystem.Particle[] particleArray;

	private ParticleSystem particleSys;

	private float time;

	private int currentSplit;

	private float fpsTime;

	private int FPS;

	private int splitUpdate;

	private RFX4_Turbulence.PerfomanceEnum perfomanceOldSettings;

	private bool skipFrame;

	private Transform t;

	private float currentDelay;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePerfomanceSettings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTurbulence()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_Turbulence()
	{
		throw null;
	}

	public enum MoveMethodEnum
	{
		Position,
		Velocity,
		RelativePosition
	}

	public enum PerfomanceEnum
	{
		High,
		Low
	}
}
