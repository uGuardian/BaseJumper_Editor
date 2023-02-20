using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CircusMapFilter : MonoBehaviour
{
	public AudioClip unionClipRef;

	public AudioClip separateClipRef;

	public SpriteRenderer bg;

	public SpriteRenderer fg;

	public SpriteRenderer silhouette_union;

	public SpriteRenderer silhouette_seperation;

	public AnimationCurve silhouetteAlphaCurve;

	private bool _bRoutineRunning;

	public bool IsRoutineRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter(bool union)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FilterRoutine(bool union)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircusMapFilter()
	{
		throw null;
	}
}
