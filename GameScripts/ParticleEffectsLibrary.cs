using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleEffectsLibrary : MonoBehaviour
{
	public static ParticleEffectsLibrary GlobalAccess;

	public int TotalEffects;

	public int CurrentParticleEffectIndex;

	public int CurrentParticleEffectNum;

	public Vector3[] ParticleEffectSpawnOffsets;

	public float[] ParticleEffectLifetimes;

	public GameObject[] ParticleEffectPrefabs;

	private string effectNameString;

	private List<Transform> currentActivePEList;

	private Vector3 spawnPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCurrentPENameString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PreviousParticleEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NextParticleEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnParticleEffect(Vector3 positionInWorldToSpawn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParticleEffectsLibrary()
	{
		throw null;
	}
}
