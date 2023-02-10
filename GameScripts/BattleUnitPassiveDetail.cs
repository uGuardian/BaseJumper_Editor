using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleUnitPassiveDetail
{
	private BattleUnitModel _self;

	private List<PassiveAbilityBase> _passiveList;

	private List<PassiveAbilityBase> _readyPassiveList;

	public List<PassiveAbilityBase> PassiveList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<PassiveAbilityBase> ReadyPassiveList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitPassiveDetail(BattleUnitModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasPassive<T>() where T : PassiveAbilityBase
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasPassiveInReady<T>() where T : PassiveAbilityBase
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbilityBase AddPassive(PassiveAbilityBase passive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbilityBase AddPassive(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyPassive(PassiveAbilityBase passive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyPassiveAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SpeedDiceBreakAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxHpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEmotionCoinAdder(int defaultCount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AllowTargetChanging(BattleUnitModel attacker, int myIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> ChangeSubTargets(BattleDiceCardModel card, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReductionAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReductionAll(int dmg, DamageType dmgType, BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTakenGuardBreakDamageAdder(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDiceResult(BattleDiceBehavior behavior, ref int diceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterGiveDamage(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincible()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleBp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKnockoutInsteadOfDeath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmortal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMinHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsStraighten()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneByFarAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable_theLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNegativeHalfExceptBurn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDamageReductionForEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUnitCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd_alive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAddBuf(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterRollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartOneSideAction(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedByAreaAtk(BattlePlayingCardDataInUnitModel attackerCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdateInWaitPhase(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_before()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEndTheLast_ignoreDead()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAreaAttack(BattleDiceBehavior behavior, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAttackEvent(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int breakdmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRecoverHp(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRecoverBreak(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRecoverHp(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BeforeTakeBreakDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseHp(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKill(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDiscardByAbility(List<BattleDiceCardModel> cards)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSide()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideVictim(BattlePlayingCardDataInUnitModel attackerCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnAddKeywordBufByCard(BattleUnitBuf buf, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAddKeywordBufByCardForEvent(KeywordBuf keywordBuf, int stack, BufReadyType readyType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnGiveKeywordBufByCard(BattleUnitBuf buf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMultiplierOnGiveKeywordBufByCard(BattleUnitBuf buf, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetStartHp(float hp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnReleaseBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLevelUpEmotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPriorityAdder(BattleDiceCardModel card, int speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGainChargeStack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseChargeStack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnOtherUnitReservedCostChanged(BattleUnitModel unit, int cur)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMakeBreakState(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel OnSelectCardAuto(BattleDiceCardModel origin, int currentDiceSlotIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DontChangeResistByBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDiceInRencounter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float BreakDmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneBreakDmg(DamageType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExhaustBullet()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TeamKill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCheckEndBattle(ref bool librarianExists, ref bool enemyExists)
	{
		throw null;
	}
}
