using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_KingOfGreed : EnemyTeamStageManager
{
	private EnemyTeamStageManager_KingOfGreed.Phase _currentPhase;

	private bool _finished;

	private EnemyTeamStageManager_KingOfGreed.Phase _filterCheckPhase;

	public EnemyTeamStageManager_KingOfGreed.Phase currentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool Finished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
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
	public override bool IsStageFinishable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhase(EnemyTeamStageManager_KingOfGreed.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateUnit(int enemyUnitId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetChangePhaseFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_KingOfGreed()
	{
		throw null;
	}

	public enum Phase
	{
		Amber,
		Reason,
		NoReason
	}
}
