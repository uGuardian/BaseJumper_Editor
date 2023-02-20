using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HurtFlashEffect : MonoBehaviour
{
	private const int DefaultFlashCount = 3;

	public int flashCount;

	public Color flashColor;

	[Range(0.008333334f, 0.06666667f)]
	public float interval;

	public string fillPhaseProperty;

	public string fillColorProperty;

	private MaterialPropertyBlock mpb;

	private MeshRenderer meshRenderer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Flash()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FlashRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HurtFlashEffect()
	{
		throw null;
	}
}
