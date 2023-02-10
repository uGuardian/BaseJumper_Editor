using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AutoDestruct : MonoBehaviour
{
	public float time;

	private float _elapsedTime;

	[SerializeField]
	private bool _bDestroyWhenDisable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyWhenDisable()
	{
		throw null;
	}

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
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoDestruct()
	{
		throw null;
	}
}
