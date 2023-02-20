using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class RFX4_ColorHelper
{
	private const float TOLERANCE = 0.0001f;

	private static string[] colorProperties;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RFX4_ColorHelper.HSBColor ColorToHSV(Color color)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color HSVToColor(RFX4_ColorHelper.HSBColor hsbColor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color ConvertRGBColorByHUE(Color rgbColor, float hue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ChangeObjectColorByHUE(GameObject go, float hue)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Material setMatHUEColor(Material mat, string name, float hueColor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Material setMatAlphaColor(Material mat, string name, float alpha)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RFX4_ColorHelper()
	{
		throw null;
	}

	public struct HSBColor
	{
		public float H;

		public float S;

		public float B;

		public float A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HSBColor(float h, float s, float b, float a)
		{
			throw null;
		}
	}
}
