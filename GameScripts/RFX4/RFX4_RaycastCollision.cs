using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_RaycastCollision : MonoBehaviour
{
	public float RaycastDistance;

	public GameObject[] Effects;

	public float Offset;

	public float TimeDelay;

	public float DestroyTime;

	public bool UsePivotPosition;

	public bool UseNormalRotation;

	public bool IsWorldSpace;

	public bool RealTimeUpdateRaycast;

	public bool DestroyAfterDisabling;

	[HideInInspector]
	public float HUE;

	[HideInInspector]
	public List<GameObject> CollidedInstances;

	private bool isInitialized;

	private bool canUpdate;

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
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateRaycast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_RaycastCollision()
	{
		throw null;
	}
}
