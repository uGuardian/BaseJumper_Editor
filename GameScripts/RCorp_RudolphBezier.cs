using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RCorp_RudolphBezier : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private int _quantizeCount;

	[SerializeField]
	private Transform[] _controlPoints;

	[SerializeField]
	private float yRandomOffset;

	[SerializeField]
	private float zRandomOffset;

	[Header("Runtime")]
	[SerializeField]
	private RCorp_RudolphBezier _prev;

	[SerializeField]
	private RCorp_RudolphBezier _next;

	public int QuantizeCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 startPos, Vector3 lastPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeStartAndLasPos(Vector3 startPos, Vector3 lastPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeIntermediatePosWithOffset(int index, float y, float z)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrevBezier(RCorp_RudolphBezier prev)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNextBezier(RCorp_RudolphBezier next)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPos(float t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetPosByThreeCp(float t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 GetPosByFourCp(float t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RCorp_RudolphBezier()
	{
		throw null;
	}
}
