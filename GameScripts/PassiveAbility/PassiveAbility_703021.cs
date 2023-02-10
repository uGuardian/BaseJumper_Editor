using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_703021 : PassiveAbilityBase
{
	private const int _houseID = 9070301;

	private const int _cowardID = 9070303;

	private const int _targetCardID = 970321;

	private const int _attackCardID = 970322;

	private const int _superCardID = 970323;

	private const int _speedDiceNum = 3;

	private int _blockedAtkMax;

	private int blockedAtkCnt;

	private bool defeat;

	private WayBackHomeMapManager _map;

	private BattleUnitBuf_WayBackHome_Super_Cancel _buf;

	private WayBackHomeMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BattleUnitBuf_WayBackHome_Super_Cancel Buf
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart1st()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart2nd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStartSuper()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnLoseParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BlockedAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<BattleUnitModel> ChangeSubTargets(BattleDiceCardModel card, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBreakState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnReleaseBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetHouse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetTargetsIn1stLane()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetTargetsIn2ndLane()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetTargetsIn3rdLane()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTargetTarget1st()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTargetTarget2nd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTarget1st()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTarget2nd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTarget3rd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_703021()
	{
		throw null;
	}
}
