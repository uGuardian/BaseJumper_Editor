using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class UserCamera : MonoBehaviour
{
	public Transform target;

	public float yOffset;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float distanceMin;

	public float distanceMax;

	private float x;

	private float y;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ClampAngle(float angle, float min, float max)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserCamera()
	{
		throw null;
	}
}
