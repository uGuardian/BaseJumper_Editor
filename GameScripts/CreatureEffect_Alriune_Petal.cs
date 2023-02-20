using System;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;
using UnityEngine;

public class CreatureEffect_Alriune_Petal : CreatureEffect
{
	[SerializeField]
	private GameObject[] _petalObject;

	[SerializeField]
	private GameObject[] _petalEffect;

	private const int _petalMax = 3;

	private int _petalCnt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect_Alriune_Petal()
	{
		throw null;
	}
}
