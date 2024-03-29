﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class BattleUnitBuf
{
	private bool _destroyed;

	public bool hide;

	public int stack;

	private bool _iconInit;

	private Sprite _bufIcon;

	protected BattleUnitModel _owner;

	public static Dictionary<string, Sprite> _bufIconDictionary;

	public virtual bool IsControllable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool Hide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual int paramInBufDesc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual KeywordBuf bufType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool independentBufIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected virtual string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected virtual string keywordIconId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual BufPositiveType positiveType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool isAssimilation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string bufActivatedName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string bufActivatedNameWithStack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual string bufActivatedText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string bufKeywordText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAddBuf(int addedStack)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Destroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDestroyed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool NullifyNotTargetable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTargetable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTauntable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTargetable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsCardChoosable(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<BattleUnitModel> GetFixedTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsInvincibleHp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsInvincibleBp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDieForReadybuf()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual StatBonus GetStatBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetBreakDamageReduction(BehaviourDetail behaviourDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetEmotionCoinAdder(int defaultCount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetBreakDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetDamageReductionRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetBreakDamageReductionRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetDamageReductionAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetBufIcon()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAfterRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterDiceAction(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSuccessAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLoseParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPrintEffect(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFriendTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsAttackDice(BehaviourDetail diceDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsDefenseDice(BehaviourDetail diceDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndBattlePhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLayerChanged(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollDiceInRecounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnHpZero()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRecoverHp(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRecoverBreak(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleBufUIData GetUIData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool DirectAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartOneSideAction(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeLoseHPNotDmg(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLoseHp(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmortal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsStraighten()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float BreakDmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmuneBreakDmg(DamageType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmune(BufPositiveType posType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmune(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsImmuneDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TeamKill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsNullifiedPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsHalfPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int OnGiveKeywordBufByCard(BattleUnitBuf cardBuf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMultiplierOnGiveKeywordBufByCard(BattleUnitBuf cardBuf, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCardCostAdder(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMinHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAddTextData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangeDiceResult(BattleDiceBehavior behavior, ref int diceResult)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BattleUnitBuf()
	{
		throw null;
	}
}
