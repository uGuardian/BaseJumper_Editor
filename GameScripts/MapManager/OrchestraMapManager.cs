using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class OrchestraMapManager : CreatureMapManager
{
	private bool _secondPhase;

	[SerializeField]
	private Animator _curtainAnimator;

	[SerializeField]
	private AudioClip _curtainOpenSound;

	[SerializeField]
	private AudioClip _curtainCloseSound;

	private List<OrchestraMap_Movement> _activatedList;

	private SoundEffectPlayer _curtainCloseSoundInstance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurtainFilter(bool open)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMapSound(int pattern)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCurtainFilterAnimEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
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
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrchestraMapManager()
	{
		throw null;
	}
}
