using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CircusMapManager : MapManager
{
	public AudioClip noahDeadClipRef;

	[SerializeField]
	private List<SpriteRenderer> _brightSpriteList;

	[SerializeField]
	private List<GameObject> _createdScratches;

	[SerializeField]
	private CircusMapFilter _filter;

	[SerializeField]
	private SpriteRenderer _weakFilter;

	private bool _bBrightness;

	private bool b;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GameObject GetScratch(int lv, Transform parent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMapBrightness(bool isBright)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter(bool union)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BrightRoutine(bool isBright)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircusMapManager()
	{
		throw null;
	}
}
