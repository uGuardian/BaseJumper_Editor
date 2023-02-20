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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateRaycast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_RaycastCollision()
	{
		throw null;
	}
}
