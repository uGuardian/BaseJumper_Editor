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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoDestruct()
	{
		throw null;
	}
}
