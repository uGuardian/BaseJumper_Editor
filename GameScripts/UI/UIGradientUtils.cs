using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public static class UIGradientUtils
	{
		private static Vector2[] ms_verticesPositions;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static UIGradientUtils.Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir)
		{
			throw null;
		}

		public static Vector2[] VerticePositions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 RotationDir(float angle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float InverseLerp(float a, float b, float v)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c)
		{
			
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIGradientUtils()
		{
			throw null;
		}

		public struct Matrix2x3
		{
			public float m00;

			public float m01;

			public float m02;

			public float m10;

			public float m11;

			public float m12;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static Vector2 operator *(UIGradientUtils.Matrix2x3 m, Vector2 v)
			{
				throw null;
			}
		}
	}
}
