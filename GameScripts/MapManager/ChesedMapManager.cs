using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChesedMapManager : MapManager
{
	[SerializeField]
	private SpriteRenderer bg1;

	[SerializeField]
	private SpriteRenderer bg2;

	[SerializeField]
	private Animator Animator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChesedMapManager()
	{
		throw null;
	}
}
