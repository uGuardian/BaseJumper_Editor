using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class SpriteRendererExt
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetActiveBounds(this SpriteRenderer instance, ref float minX, ref float minY, ref float maxX, ref float maxY, bool includeChildren = false, Func<GameObject, Sprite, bool> shouldIgnoreSprite = null)
	{
		
	}
}
