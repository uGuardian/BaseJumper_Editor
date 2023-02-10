using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Test : MonoBehaviour
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Test()
	{
		throw null;
	}
}
