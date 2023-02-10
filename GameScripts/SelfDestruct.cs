using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
	public float selfdestruct_in;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SelfDestruct()
	{
		throw null;
	}
}
