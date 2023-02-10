using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
	public float fireRate;

	public float weaponRange;

	public Transform gunEnd;

	public ParticleSystem muzzleFlash;

	public ParticleSystem cartridgeEjection;

	public GameObject metalHitEffect;

	public GameObject sandHitEffect;

	public GameObject stoneHitEffect;

	public GameObject waterLeakEffect;

	public GameObject waterLeakExtinguishEffect;

	public GameObject[] fleshHitEffects;

	public GameObject woodHitEffect;

	private float nextFire;

	private Animator anim;

	private GunAim gunAim;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleHit(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpawnDecal(RaycastHit hit, GameObject prefab)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GunShoot()
	{
		throw null;
	}
}
