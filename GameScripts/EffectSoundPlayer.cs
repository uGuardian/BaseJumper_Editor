﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EffectSoundPlayer : MonoBehaviour
{
	public AudioSource audioSrc;

	private float _length;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(AudioClip ac, float volume = 1f, bool loop = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EffectSoundPlayer()
	{
		throw null;
	}
}
