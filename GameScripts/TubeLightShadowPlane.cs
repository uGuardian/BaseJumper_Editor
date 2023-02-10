using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TubeLightShadowPlane : MonoBehaviour
{
	[MinValue(0f)]
	public float m_Feather;

	public float feather
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4 GetShadowPlaneVector()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TubeLightShadowPlane()
	{
		throw null;
	}

	public struct Params
	{
		public Vector4 plane;

		public float feather;
	}
}
