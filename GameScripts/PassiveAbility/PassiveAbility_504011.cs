using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_504011 : PassiveAbilityBase
{
	private const int _reclusID = 9050402;

	private const int _dollID = 9050403;

	private const int _atkCardID = 950411;

	private const int _atkStrongCardID = 950412;

	private const int _counterCardID = 950413;

	private const int _areaCardID = 950414;

	private const int _areaDmgCondition = 30;

	private const int _areaCoolTimeMax = 2;

	private const int _speedDiceNum = 3;

	private int _areaCoolTime;

	private int _accumulatedDmg;

	private ServantOfWrathMapManager _map;

	private ServantOfWrathMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillAllLibrarians()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<BattleUnitModel> ChangeSubTargets(BattleDiceCardModel card, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetReclus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetDolls()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_DollAlive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_DollAllKilled()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_SummoningDoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetAreaCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_504011()
	{
		throw null;
	}
}
