using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class YieldCache
{
	public static readonly WaitForEndOfFrame waitFrame;

	public static readonly WaitForFixedUpdate waitFixedUpdate;

	private static readonly Dictionary<float, WaitForSeconds> _waitSecondsDic;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static WaitForSeconds WaitForSeconds(float seconds)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static YieldCache()
	{
		throw null;
	}

	private class FloatComparer : IEqualityComparer<float>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IEqualityComparer<float>.Equals(float x, float y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		int IEqualityComparer<float>.GetHashCode(float obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FloatComparer()
		{
			throw null;
		}
	}
}
