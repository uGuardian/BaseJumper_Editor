using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class MountainMapManager : CreatureMapManager
{
	private MountainMapManager.State _curState;

	private Dictionary<MountainMapManager.State, CreatureBattleDlgInfo> _dlgEffectDic;

	private CreatureDlgEffectUI _curMountainDlg;

	private CreatureDlgEffectUI _curChildDlg;

	[SerializeField]
	private AudioClip _soundRes;

	private SoundEffectPlayer _loopBgSound;

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
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChildDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDialog(bool isBossPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MountainMapManager()
	{
		throw null;
	}

	private enum State
	{
		Always,
		PhaseZero,
		PhaseOne,
		PhaseTwo,
		PhaseThree
	}
}
