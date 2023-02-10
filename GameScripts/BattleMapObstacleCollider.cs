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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider other)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OffCollider()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleMapObstacleCollider()
	{
		throw null;
	}
}
