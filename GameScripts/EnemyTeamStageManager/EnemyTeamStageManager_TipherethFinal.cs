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
		throw null;
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
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsStageFinishable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_TipherethFinal.Phase nextPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateHatredUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateDespairUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGreedPhaseOneUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGreedPhaseTwoUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateWrathUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateNihilUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStartDialog()
	{
		throw null;
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
