using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_504021 : PassiveAbilityBase
{
	private const int _servantID = 9050401;

	private const int _dollID = 9050403;

	private const int _areaCard1stID = 950421;

	private const int _bufCardID = 950422;

	private const int _evadeCardID = 950423;

	private const int _wandDebufCardID = 950424;

	private const int _wandAtkCardID = 950425;

	private const int _summonCardID = 950426;

	private const int _speedDiceNum = 3;

	private const int _powerParryingServant = 5;

	private const int _maxDollCnt = 3;

	private const int _areaCoolTimeMax = 2;

	private const int _dmgCut = 30;

	private const float _healRate = 0.5f;

	private bool _summon;

	private int _areaCoolTime;

	private ServantOfWrathMapManager _map;

	public override bool isImmortal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
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
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetServant()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetDolls()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SummonDolls()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_DollAlive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_DollAllKilled()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_SummoningDoll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDeadEvent(BattleUnitView ownerView)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WinDirection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DirectionCoroutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_504021()
	{
		throw null;
	}
}
