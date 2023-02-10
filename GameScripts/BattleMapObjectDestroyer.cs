using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleMapObjectDestroyer : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;

	[SerializeField]
	private List<BoxCollider> _pieceColliderList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTriggerEnter(Collider other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCollisionEnter(Collision collision)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCollision(string tag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleMapObjectDestroyer()
	{
		throw null;
	}
}
