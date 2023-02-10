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
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChildDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDialog(bool isBossPhase)
	{
		throw null;
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
