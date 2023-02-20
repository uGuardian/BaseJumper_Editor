using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CompetitionTrail_R : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem dustParticle_lv1;

	[SerializeField]
	private ParticleSystem dustParticle_lv2;

	[SerializeField]
	private ParticleSystem emberParticle;

	[SerializeField]
	private Transform t;

	public int particleLevel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Transform parent, int particleLevel = 3)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompetitionTrail_R()
	{
		throw null;
	}
}
