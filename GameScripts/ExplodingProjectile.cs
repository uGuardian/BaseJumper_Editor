using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExplodingProjectile : MonoBehaviour
{
	public GameObject impactPrefab;

	public GameObject explosionPrefab;

	public float thrust;

	public Rigidbody thisRigidbody;

	public GameObject particleKillGroup;

	private Collider thisCollider;

	public bool LookRotation;

	public bool Missile;

	public Transform missileTarget;

	public float projectileSpeed;

	public float projectileSpeedMultiplier;

	public bool ignorePrevRotation;

	public bool explodeOnTimer;

	public float explosionTimer;

	private float timer;

	private Vector3 previousPosition;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCollision(Vector3 prevPos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision collision)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Explode()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExplodingProjectile()
	{
		throw null;
	}
}
