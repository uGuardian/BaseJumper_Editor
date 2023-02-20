using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightManager<T> : MonoBehaviour
{
	private static LightManager<T> s_Instance;

	private HashSet<T> m_Container;

	private static LightManager<T> Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HashSet<T> Get()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Add(T t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Remove(T t)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightManager()
	{
		throw null;
	}
}
