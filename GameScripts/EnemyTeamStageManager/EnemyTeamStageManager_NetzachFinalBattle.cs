using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_NetzachFinalBattle : EnemyTeamStageManager
{
	private const int ANGELA_UNIVERSE_ID = 9040511;

	private const int ANGELA_GALAXY_ID = 9040521;

	private const int ANGELA_PORCCUBUS_ID = 9040531;

	private const int ANGELA_ALRIUNE_ID = 9040541;

	private const int ANGELA_ORCHESTRA_FIRST_ID = 9040551;

	private const int ANGELA_ORCHESTRA_SECOND_ID = 9040561;

	private EnemyTeamStageManager_NetzachFinalBattle.Phase _currentPhase;

	private bool _bFinishable;

	public EnemyTeamStageManager_NetzachFinalBattle.Phase CurrentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public void SetFinishable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_NetzachFinalBattle.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateUniverseFragment()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGalaxyChild()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePorccubus()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateAlriune()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateOrchestraFirstPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateOrchestraSecondPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_NetzachFinalBattle()
	{
		throw null;
	}

	public enum Phase
	{
		PORCCUBUS,
		UNIVERSE,
		GALAXY,
		ORCHESTRA_FIRST,
		ALRIUNE,
		ORCHESTRA_SECOND
	}
}
