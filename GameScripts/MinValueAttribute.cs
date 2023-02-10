using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MinValueAttribute : PropertyAttribute
{
	public float min;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MinValueAttribute(float min)
	{
		throw null;
	}
}
