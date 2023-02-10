using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CraterBehavior : MonoBehaviour
{
	[SerializeField]
	private Texture[] _scratchTextures;

	[SerializeField]
	private Projector _projector;

	[SerializeField]
	private ParticleSystem _pieceParticle;

	[SerializeField]
	private Transform _ground;

	private const float _collideDuration = 10f;

	private float _elapsedTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitFields(int lv, Transform ground, float angle, int sign = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator CollideParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CraterBehavior()
	{
		throw null;
	}
}
