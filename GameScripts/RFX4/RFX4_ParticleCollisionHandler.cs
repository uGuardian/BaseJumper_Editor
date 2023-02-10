using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RFX4_ParticleCollisionHandler : MonoBehaviour
{
	public GameObject[] EffectsOnCollision;

	public float Offset;

	public float DestroyTimeDelay;

	public bool UseWorldSpacePosition;

	private ParticleSystem part;

	private List<ParticleCollisionEvent> collisionEvents;

	private ParticleSystem ps;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnParticleCollision(GameObject other)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_ParticleCollisionHandler()
	{
		throw null;
	}
}
