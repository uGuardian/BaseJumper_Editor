using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static bool _isQuit;

	public static T Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnApplicationQuit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonBehavior()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonBehavior()
	{
		throw null;
	}
}
