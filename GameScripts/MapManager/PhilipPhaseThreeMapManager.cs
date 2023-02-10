using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhilipPhaseThreeMapManager : MapManager
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBurnFilterSprite()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayMapChangedSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BurnFilterRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PhilipPhaseThreeMapManager()
	{
		throw null;
	}
}
