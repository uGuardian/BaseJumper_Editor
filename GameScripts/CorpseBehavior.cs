using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CorpseBehavior : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _corpseParticle;

	[SerializeField]
	private Transform _ground;

	private const float _collideDuration = 10f;

	private float _elapsedTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitFields(Vector2 dir, Transform ground)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator CollideParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CorpseBehavior()
	{
		throw null;
	}
}
