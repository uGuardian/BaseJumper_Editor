using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RFX4_ParticleLight : MonoBehaviour
{
	public float LightIntencityMultiplayer;

	public LightShadows Shadows;

	private ParticleSystem ps;

	private ParticleSystem.Particle[] particles;

	private Light[] lights;

	private int lightLimit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_ParticleLight()
	{
		throw null;
	}
}
