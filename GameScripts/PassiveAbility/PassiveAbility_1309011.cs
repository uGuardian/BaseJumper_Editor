using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1309011 : PassiveAbilityBase
{
	private const int _GIVING_CONTRACT_1_CARD_ID = 703901;

	private const int _GIVING_CONTRACT_2_CARD_ID = 703902;

	private const int _GIVING_CONTRACT_3_CARD_ID = 703903;

	private const int _GIVING_CONTRACT_4_CARD_ID = 703904;

	private const int _GIVING_CONTRACT_5_CARD_ID = 703905;

	private const int _STRONG_ATK_1_CARD_ID = 703911;

	private const int _STRONG_ATK_2_CARD_ID = 703912;

	private const int _STRONG_ATK_3_CARD_ID = 703913;

	private const int _WEAK_ATK_CARD_ID = 703914;

	private const int _BARRIER_CARD_ID = 703915;

	private const int _SUMMON_CARD_ID = 703916;

	private const int _CHANGE_HP_CARD_ID = 703917;

	private const int _AREA_ATK_CARD_ID = 703918;

	private PassiveAbility_1309011.PhasePattern _phasePattern;

	private const int _AREA_ATK_COOLDOWN = 5;

	private int _curAreaAtkCoolDown;

	private List<BattleUnitModel> _barrierUnitList;

	private bool _bChangeHp;

	private int _defensedUnitCountByAreaAtk;

	private List<BattleUnitModel> _contractedList;

	private string _PREFAB_PATH;

	public PassiveAbility_1309011.PhasePattern phasePattern
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDefensedUnitCountByAreaAtk(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSummonUnit(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseChangeHpCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddStrongAtkCardByRandom(int priorityAdder)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id, int priorityAdder)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeBookResist()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyPassive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhaseTwo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeHp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TakeBreakDamageByAreaAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SummonUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SummonPhaseOneUnits()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterPuppets()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1309011()
	{
		throw null;
	}

	public enum PhasePattern
	{
		PHASE_ONE_FIRST,
		PHASE_ONE_SECOND,
		PHASE_ONE_THIRD,
		PHASE_TWO_FIRST,
		PHASE_TWO_SECOND,
		PHASE_TWO_THIRD
	}
}
