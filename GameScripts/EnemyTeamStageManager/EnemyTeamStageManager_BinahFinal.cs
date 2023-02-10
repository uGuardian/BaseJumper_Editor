using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_BinahFinal : EnemyTeamStageManager
{
	private const int _BIG_BIRD_EGO_ID = 9080511;

	private const int _PUNISHING_BIRD_EGO_ID = 9080521;

	private const int _JUDGEMENT_BIRD_EGO_ID = 9080531;

	private const int _APOCALYPSE_BIRD_EGO_ID = 9080541;

	private EnemyTeamStageManager_BinahFinal.Phase _curPhase;

	private bool _bFinishable;

	public EnemyTeamStageManager_BinahFinal.Phase CurrentPhase
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
	public override bool IsStageFinishable()
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
	private void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_BinahFinal.Phase nextPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBigBirdUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePunishingBirdUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateJudgementBirdUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateApocalypseBirdUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecoverLibrarianHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayImageFilter(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_BinahFinal()
	{
		throw null;
	}

	public enum Phase
	{
		BIG,
		PUNISHING,
		JUDGEMENT,
		APOCALYPSE
	}
}
