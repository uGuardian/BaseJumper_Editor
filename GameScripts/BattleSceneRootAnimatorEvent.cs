using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleSceneRootAnimatorEvent : MonoBehaviour
{
	[SerializeField]
	private BattleSceneRoot root;

	[SerializeField]
	private AudioSource audioSrc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent(int flag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleSceneRootAnimatorEvent()
	{
		throw null;
	}
}
