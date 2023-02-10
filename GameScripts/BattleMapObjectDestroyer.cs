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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCollisionEnter(Collision collision)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCollision(string tag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleMapObjectDestroyer()
	{
		throw null;
	}
}
