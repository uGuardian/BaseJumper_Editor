using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EnemyTeamStageManager_HokmaFinal : EnemyTeamStageManager
{
	public const int _PLAGUE_DOCTOR_ID = 9090511;

	public const int _WHITE_NIGHT_ID = 9090521;

	public const int _ESCORT_APOSTLE_ID = 9090512;

	public const int _SCYTHE_APOSTLE_ID = 9090513;

	public const int _STAFF_APOSTLE_ID = 9090514;

	public const int _SPEAR_APOSTLE_ID = 9090515;

	private bool _bFinishable;

	private bool _bNewPhaseRoundStart;

	private EnemyTeamStageManager_HokmaFinal.Phase _curPhase;

	private List<BattleUnitModel> _deadApostleList;

	public EnemyTeamStageManager_HokmaFinal.Phase curPhase
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
	public void SetDeadApostle(BattleUnitModel unit)
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
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayDeadApostleEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStartBattleDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_HokmaFinal.Phase newPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHokmaBuf()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhaseOnePassive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePhaseTwoUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetEscortApostleInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePhaseThreeUnit(List<BattleUnitModel> escortApostleList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_HokmaFinal()
	{
		throw null;
	}

	public enum Phase
	{
		ONE,
		TWO,
		THREE
	}
}
