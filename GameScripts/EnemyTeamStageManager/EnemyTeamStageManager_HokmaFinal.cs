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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeadApostle(BattleUnitModel unit)
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
	private void PlayDeadApostleEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStartBattleDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(EnemyTeamStageManager_HokmaFinal.Phase newPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHokmaBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPhaseOnePassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePhaseTwoUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetEscortApostleInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePhaseThreeUnit(List<BattleUnitModel> escortApostleList)
	{
		throw null;
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
