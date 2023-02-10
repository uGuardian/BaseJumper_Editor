using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Wind : MonoBehaviour
{
	[MinValue(0f)]
	public float m_Speed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Wind()
	{
		throw null;
	}
}
