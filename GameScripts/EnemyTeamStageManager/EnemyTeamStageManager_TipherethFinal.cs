using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_TipherethFinal : EnemyTeamStageManager
{
	private const int HATRED_ID = 9050511;

	private const int DESPAIR_ID = 9050521;

	private const int GREED_ONE_ID = 9050531;

	private const int GREED_TWO_ID = 9050532;

	private const int WRATH_ID = 9050541;

	private const int NIHIL_ID = 9050550;

	private EnemyTeamStageManager_TipherethFinal.Phase _curPhase;

	private bool _bFinishable;

	private bool _bNewPhaseStarted;

	public EnemyTeamStageManager_TipherethFinal.Phase CurrentPhase
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
	private void SetNewPhase(EnemyTeamStageManager_TipherethFinal.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateHatredUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDespairUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGreedPhaseOneUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGreedPhaseTwoUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateWrathUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateNihilUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStartDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_TipherethFinal()
	{
		throw null;
	}

	public enum Phase
	{
		HATRED,
		DESPAIR,
		GREED_1,
		GREED_2,
		WRATH,
		NIHIL
	}
}
