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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCollision(Vector3 prevPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionEnter(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Explode()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExplodingProjectile()
	{
		throw null;
	}
}
