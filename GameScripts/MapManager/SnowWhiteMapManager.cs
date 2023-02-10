using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SnowWhiteMapManager : CreatureMapManager
{
	[SerializeField]
	private List<SpriteGhostEffect> _vineFloorEffects;

	[SerializeField]
	private SpriteRenderer _vineFilter;

	public FarAreaEffect_SnowWhiteStrongVine _strongVineAtkEffect;

	private float _curVineRatio;

	private float _dstVineRatio;

	private int _vineFilterCount;

	private CameraFilterPack_TV_BrokenGlass broken1;

	private CameraFilterPack_TV_BrokenGlass2 broken2;

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
	public void SetFloorFilter(int round)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartStrongVine(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowWhiteMapManager()
	{
		throw null;
	}
}
