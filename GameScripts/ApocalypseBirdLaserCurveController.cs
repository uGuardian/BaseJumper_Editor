using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ApocalypseBirdLaserCurveController : MonoBehaviour
{
	[SerializeField]
	private Transform[] _controlPoints;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastPos(Vector3 worldPos)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPos(float ratio)
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

	}
}
