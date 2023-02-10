using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleUnitBufListDetail
{
	private BattleUnitModel _self;

	private List<BattleUnitBuf> _bufList;

	private List<BattleUnitBuf> _readyBufList;

	private List<BattleUnitBuf> _readyReadyBufList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBufListDetail(BattleUnitModel model)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckDestroyedBuf()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleHp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleBp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetFixedTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTauntable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReduction(BehaviourDetail behaviourDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReductionAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEmotionCoinAdder(int defaultCount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetDamageRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetBreakDamageRate()
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
	public void OnRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLayerChanged(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitBuf> GetActivatedBufList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf GetActivatedBuf(KeywordBuf bufType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitBuf> GetReadyBufList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf GetReadyBuf(KeywordBuf bufType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitBuf> GetReadyReadyBufList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNegativeBufTypeCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleBufUIDataList GetBufUIDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAddBuf(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddReadyBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddReadyReadyBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckBufCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufWithoutDuplication(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufWithConnection(BattleUnitBuf buf, BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitBuf AddNewKeywordBufInList(BufReadyType readyType, KeywordBuf bufType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ModifyStack(BattleUnitBuf buf, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddKeywordBufThisRoundByEtc(KeywordBuf bufType, int stack, BattleUnitModel actor = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddKeywordBufByEtc(KeywordBuf bufType, int stack, BattleUnitModel actor = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddKeywordBufThisRoundByCard(KeywordBuf bufType, int stack, BattleUnitModel actor = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddKeywordBufByCard(KeywordBuf bufType, int stack, BattleUnitModel actor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddKeywordBufNextNextByCard(KeywordBuf bufType, int stack, BattleUnitModel actor = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBufAll(Type buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBufAll(KeywordBuf bufType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBufAll(BufPositiveType bufPositiveType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBufAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveReadyBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGift(KeywordBuf bufType, int stack, BattleUnitModel actor = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckAchievements()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckAllBufForAchievement()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NotTargetableRemoved()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsControlable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCardChoosable(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatBonus GetStatBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetKewordBufStack(KeywordBuf keyword)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetKewordBufAllStack(KeywordBuf keyword)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasBuf<T>()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasStun()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterDiceAction(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSuccessAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFriendTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDiceInReencounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnHpZero()
	{
		
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
	public bool DirectAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartOneSideAction(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNullifyPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHalfPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeLoseHPNotDmg(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseHp(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsStraighten()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmortal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmune(BufPositiveType buf)
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
	public void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TeamKill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnGiveKeywordBufByCard(BattleUnitBuf targetBuf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMultiplierOnGiveKeywordBufByCard(BattleUnitBuf targetBuf, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardCostAdder(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMinHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasAssimilation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDiceResult(BattleDiceBehavior behavior, ref int diceResult)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}
}
