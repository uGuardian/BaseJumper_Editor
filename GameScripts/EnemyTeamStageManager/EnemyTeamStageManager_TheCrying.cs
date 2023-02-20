using System;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_TheCrying : EnemyTeamStageManager
{
	private EnemyTeamStageManager_TheCrying.Phase _currentPhase;

	private int _stack;

	private bool _finished;

	private bool _weak;

	private bool _recover;

	public EnemyTeamStageManager_TheCrying.Phase currentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Stack
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
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool HideEnemyTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BlockEnemyAggroChange()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsHideDiceAbilityInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAllEnemyEquipCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllWeak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhase(EnemyTeamStageManager_TheCrying.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateTheOneUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateFiveChildren()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel AddNewChild(int id, int index, bool addAngelBuf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Phase1_AllDeadChild()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Phase2_hpLimit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStageClear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_TheCrying()
	{
		throw null;
	}

	public enum Phase
	{
		phase1,
		OneUnitPhase,
		FiveUnitPhase
	}
}
