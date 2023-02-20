using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_GeburaFinal : EnemyTeamStageManager
{
	private const int _REDHOOD_ID = 9060511;

	private const int _REDHOODWOLF_ID = 9060512;

	private const int _BIGBADWOLF_ID = 9060521;

	private const int _MOUNTAIN_ID = 9060531;

	private const int _NOSFERATU_ID = 9060541;

	private const int _NOTHING_ID = 9060551;

	private EnemyTeamStageManager_GeburaFinal.Phase _curPhase;

	private bool _bFinishable;

	private int _mountainLoseHpFirstPhase;

	private int _mountainPhaseRound_Lv0;

	private float _nothingLv3_startHpRatio;

	public EnemyTeamStageManager_GeburaFinal.Phase CurrentPhase
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
	private void SetNewPhase(EnemyTeamStageManager_GeburaFinal.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateRedHoodUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBigBadWolfUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateMountainLv0()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateMountainLv1()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateMountainLv2()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateMountainLv3()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateNosferatuUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateNothingUnit(int lv)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintMountainPhaseChangingSound(bool lvUp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_GeburaFinal()
	{
		throw null;
	}

	public enum Phase
	{
		RED_HOOD,
		BIG_BAD_WOLF,
		MOUNTAIN_LV_0,
		MOUNTAIN_LV_1,
		MOUNTAIN_LV_2,
		MOUNTAIN_LV_3,
		NOSFERATU,
		NOTHING_LV_1,
		NOTHING_LV_2,
		NOTHING_LV_3
	}
}
