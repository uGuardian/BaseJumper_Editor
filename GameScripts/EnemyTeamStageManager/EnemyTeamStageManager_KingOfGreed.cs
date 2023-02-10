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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsStageFinishable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhase(EnemyTeamStageManager_KingOfGreed.Phase nextPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateUnit(int enemyUnitId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetChangePhaseFilter()
	{
		throw null;
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
