using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ETFXProjectileScript : MonoBehaviour
{
	public GameObject impactParticle;

	public GameObject projectileParticle;

	public GameObject muzzleParticle;

	[Header("Adjust if not using Sphere Collider")]
	public float colliderRadius;

	[Range(0f, 1f)]
	public float collideOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ETFXProjectileScript()
	{
		throw null;
	}
}
