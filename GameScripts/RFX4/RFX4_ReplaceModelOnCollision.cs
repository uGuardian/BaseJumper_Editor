using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_ReplaceModelOnCollision : MonoBehaviour
{
	public GameObject PhysicsObjects;

	private bool isCollided;

	private Transform t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision collision)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_ReplaceModelOnCollision()
	{
		throw null;
	}
}
