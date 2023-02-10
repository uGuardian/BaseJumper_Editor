using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_BlackSilence : EnemyTeamStageManager
{
	private const int _NORMAL_ROLAND_ID = 60005;

	private const int _WAR_DISTORTION_ROLAND_ID = 60006;

	private const int _BLOODY_NIGHT_ROLAND_ID = 60007;

	private const int _LIBRARIAN_DISTORTION_ROLAND_ID = 60008;

	private const int _ROLAND_PHASE3_ANGELICA_ID = 60107;

	private const int _ROLAND_PHASE2_ENEMY_ID = 60106;

	private const string _ROLAND_PHASE_STORAGE_NAME = "RolandPhase";

	private const string _ROLAND_HP_STORAGE_NAME1 = "RolandHpPhase1";

	private const string _ROLAND_HP_STORAGE_NAME2 = "RolandHpPhase2";

	private const string _ROLAND_HP_STORAGE_NAME3 = "RolandHpPhase3";

	private const string _ROLAND_HP_STORAGE_NAME4 = "RolandHpPhase4";

	private bool _bFinishable;

	private BlackSilenceMapManager _phaseOneDlgManager;

	public EnemyTeamStageManager_BlackSilence.Phase curPhase
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public int thirdPhaseElapsed
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFinishable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsStageFinishable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle()
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
	private BattleUnitModel GetRoland()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetAngelica()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetRolandHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartPhaseRound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapForcely()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckThirdPhasePattern()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckSpiritLinkDestroyed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsFirstPhaseEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsSecondPhaseEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsThirdPhaseEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsFourthPhaseEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndFirstPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndSecondPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndThirdPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndFourthPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_BlackSilence.Phase newPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFirstPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSecondPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSecondPhase_restart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetThirdPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetThirdPhase_restart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFourthPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFourthPhase_restart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBgm()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecoverAllyStat()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_BlackSilence()
	{
		throw null;
	}

	public enum Phase
	{
		FIRST,
		SECOND,
		THIRD,
		FOURTH
	}
}
