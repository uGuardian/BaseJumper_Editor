using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OrchestraMap_MovementRoot : MonoBehaviour
{
	private static OrchestraMap_MovementRoot _instance;

	[SerializeField]
	private OrchestraMap_Movement[] movementEffectArray;

	private List<OrchestraMap_Movement> _activatedList;

	public static OrchestraMap_MovementRoot Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFarAreaEffect(int movement, BattleUnitModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFinaleEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrchestraMap_Movement GetFarAreaEffect(int movement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOut()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestoryRoot()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static OrchestraMap_MovementRoot CreateAndGetInstance()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrchestraMap_MovementRoot()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrchestraMap_MovementRoot()
	{
		throw null;
	}
}
