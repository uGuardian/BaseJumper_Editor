using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class HeartOfAspirationMapManager : CreatureMapManager
{
	private List<string> creatureDlgIdList;

	private CreatureDlgEffectUI dlgEffect;

	private int dlgIdx;

	private bool _bUseBeat;

	private int _roundAfterBeat;

	private Coroutine _radialRoutine;

	private SoundEffectPlayer _loopSound;

	private SoundEffectPlayer _fastSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RadialRoutine(CameraFilterPack_Blur_Radial r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeartOfAspirationMapManager()
	{
		throw null;
	}
}
