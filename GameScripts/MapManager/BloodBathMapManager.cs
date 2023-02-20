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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenEye(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EffectToTarget(BattleUnitView v)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BloodBathMapManager()
	{
		throw null;
	}
}
