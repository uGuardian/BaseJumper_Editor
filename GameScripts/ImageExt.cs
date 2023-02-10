using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public static class ImageExt
{
	private static float _anchorX;

	private static float _anchorY;

	private static float _boundsMinX;

	private static float _boundsMinY;

	private static float _boundsMaxX;

	private static float _boundsMaxY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetActiveBounds(this Image instance, ref float minX, ref float minY, ref float maxX, ref float maxY, bool includeChildren = false, Func<GameObject, Sprite, bool> shouldIgnoreSprite = null)
	{
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImageExt()
	{
		throw null;
	}
}
