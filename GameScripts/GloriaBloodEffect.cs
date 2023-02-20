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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyObject()
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
	private void UpdateRoot()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateEffect(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GloriaBloodEffect()
	{
		throw null;
	}
}
