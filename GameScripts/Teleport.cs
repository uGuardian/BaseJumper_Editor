using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public ParticleSystem TeleportVideoParticles;

	public ParticleSystem SmokeParticles;

	public ParticleSystem SparkParticles;

	public Light TeleportLight;

	public AudioSource TeleportAudio;

	private float fadeStart;

	private float fadeEnd;

	private float fadeTime;

	private float t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Teleport()
	{
		throw null;
	}
}
