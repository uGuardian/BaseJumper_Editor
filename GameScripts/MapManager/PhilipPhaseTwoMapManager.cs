using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhilipPhaseTwoMapManager : MapManager
{
	[SerializeField]
	private AudioClip _mapChangedSound;

	[SerializeField]
	private SpriteRenderer burnFilter;

	[SerializeField]
	private AnimationCurve burnCurve;

	[SerializeField]
	private List<SpriteRenderer> magmaSpriteList;

	private Color magmaColor1;

	private Color magmaColor2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBurnFilterSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayMapChangedSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BurnFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PhilipPhaseTwoMapManager()
	{
		throw null;
	}
}
