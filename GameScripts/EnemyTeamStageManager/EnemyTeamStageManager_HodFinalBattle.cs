﻿using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_HodFinalBattle : EnemyTeamStageManager
{
	private EnemyTeamStageManager_HodFinalBattle.Phase _currentPhase;

	private bool _bFinishable;

	public EnemyTeamStageManager_HodFinalBattle.Phase CurrentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFinishable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsStageFinishable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhase(EnemyTeamStageManager_HodFinalBattle.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateShyLookToday()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateRedShoes()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSpiderBud()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateLatitia()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBlackSwan()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_HodFinalBattle()
	{
		throw null;
	}

	public enum Phase
	{
		SHY_LOOK_TODAY,
		RED_SHOES,
		SPIDER_BUD,
		LATITIA,
		BLACK_SWAN
	}
}
