using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SmallBirdFinalMapManager : CreatureMapManager
{
	[SerializeField]
	private SpriteRenderer _bg;

	private SmallBirdFinalMapManager.RolandState _state;

	private bool _hit;

	public SmallBirdFinalMapManager.RolandState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRolandHit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SmallBirdFinalMapManager()
	{
		throw null;
	}

	public enum RolandState
	{
		Default,
		Evade,
		Anger
	}
}
