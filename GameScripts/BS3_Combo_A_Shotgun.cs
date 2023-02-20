using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3_Combo_A_Shotgun : BS3_Combo_Common
{
	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private AudioClip _shotgunSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Transform target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3_Combo_A_Shotgun()
	{
		throw null;
	}
}
