using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BloodBathMapManager : CreatureMapManager
{
	public Sprite[] sprites;

	public SpriteRenderer bgRenderer;

	public GameObject effect;

	private List<string> creatureDlgIdList;

	private int dlgIdx;

	private CreatureDlgEffectUI dlgEffect;

	private bool _bPalehandActivated;

	private int _roundAfterPalehand;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenEye(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EffectToTarget(BattleUnitView v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BloodBathMapManager()
	{
		throw null;
	}
}
