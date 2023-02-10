using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleMapObstacleCollider : MonoBehaviour
{
	public AudioSource audioSrc;

	public SpriteRenderer spr;

	public ParticleSystem ps;

	[SerializeField]
	protected BoxCollider _collider;

	protected bool _bCollision;

	protected float _originColliderSizeZ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnableObj(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OffCollider()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleMapObstacleCollider()
	{
		throw null;
	}
}
