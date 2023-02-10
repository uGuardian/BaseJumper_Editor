using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaLightLUT
{
	private static double[,] s_LUTTransformInv_DisneyDiffuse;

	private static float[] s_LUTAmplitude_DisneyDiffuse;

	private static double[,] s_LUTTransformInv_GGX;

	private static float[] s_LUTAmplitude_GGX;

	private static float[] s_LUTFresnel_GGX;

	private const int kLUTResolution = 64;

	private const int kLUTMatrixDim = 3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D LoadLUT(AreaLightLUT.LUTType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D CreateLUT(TextureFormat format, Color[] pixels)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D LoadLUT(double[,] LUTTransformInv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D LoadLUT(float[] LUTScalar0, float[] LUTScalar1, float[] LUTScalar2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AreaLightLUT()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AreaLightLUT()
	{
		throw null;
	}

	public enum LUTType
	{
		TransformInv_DisneyDiffuse,
		TransformInv_GGX,
		AmpDiffAmpSpecFresnel
	}
}
