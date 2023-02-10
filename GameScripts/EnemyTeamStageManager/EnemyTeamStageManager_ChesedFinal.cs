using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_ChesedFinal : EnemyTeamStageManager
{
	private const int _SCARECROW_ID = 9070511;

	private const int _LUMBERJACK_ID = 9070521;

	private const int _WAYBACKHOME_ID = 9070531;

	private const int _OZMA_ID = 9070541;

	private const int _WIZARD_ID = 9070551;

	private EnemyTeamStageManager_ChesedFinal.Phase _curPhase;

	private bool _bFinishable;

	public EnemyTeamStageManager_ChesedFinal.Phase CurrentPhase
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
	private void SetNewPhase(EnemyTeamStageManager_ChesedFinal.Phase nextPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateScareCrowUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateLumberjackUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateWaybackhomeUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateOzmaUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateWizardUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReviveLibrarians()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_ChesedFinal()
	{
		throw null;
	}

	public enum Phase
	{
		SCARECROW,
		LUMBERJACK,
		WAYBACKHOME,
		OZMA,
		WIZARD
	}
}
