using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CurveTest : MonoBehaviour
{
	[Header("Predefined")]
	public Transform[] controlPoints;

	public RectTransform[] controlRects;

	private Vector2 gizmosPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CurveTest()
	{
		throw null;
	}
}
