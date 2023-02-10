using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GloriaBloodEffect : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer _rootRenderer;

	[SerializeField]
	private ParticleSystem _particle;

	[SerializeField]
	private AnimationCurve _bgAlphaCurve;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _stopParticleTime;

	private bool _bParticleStopped;

	private float _elapsedFadeout;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateRoot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateEffect(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GloriaBloodEffect()
	{
		throw null;
	}
}
