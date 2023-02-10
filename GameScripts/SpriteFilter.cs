using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpriteFilter : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	protected float _destroyTime;

	protected bool _loop;

	protected bool _bInit;

	protected float _elapsedDestroy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(Sprite spr, bool loop, float destroyTime = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(string path, bool loop, float destroyTime = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ManualDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteFilter()
	{
		throw null;
	}
}
