using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_GeburaThird : EnemyTeamStageManager
{
	private const int _MOUNTAIN_FIRST_PHASE_ID = 9060301;

	private const int _MOUNTAIN_SECOND_PHASE_ID = 9060302;

	private const int _MOUNTAIN_THIRD_PHASE_ID = 9060303;

	private const int _MOUNTAIN_CORPSE_1 = 9060304;

	private const int _MOUNTAIN_CORPSE_2 = 9060305;

	private const int _DEFAULT_LOSEHP_FIRST_PHASE = 100;

	private const int _DEFAULT_LOSEHP_SECOND_PHASE = 100;

	private const int _DEFAULT_LOSEHP_THIRD_PHASE = 100;

	private int _loseHpFirstPhase;

	private int _elapsedRoundPhaseZero;

	private EnemyTeamStageManager_GeburaThird.Phase _curPhase;

	private bool _bStageFinishable;

	public EnemyTeamStageManager_GeburaThird.Phase CurPhase
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
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_GeburaThird.Phase newPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateZeroPhaseUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateFirstPhaseUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSecondPhaseUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateThirdPhaseUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintPhaseChangingSound(bool lvUp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_GeburaThird()
	{
		throw null;
	}

	public enum Phase
	{
		ZERO,
		FIRST,
		SECOND,
		THIRD
	}
}
