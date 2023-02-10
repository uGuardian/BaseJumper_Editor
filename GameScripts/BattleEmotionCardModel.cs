using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using LOR_XML;
using UnityEngine;

public class BattleEmotionCardModel
{
	private EmotionCardXmlInfo _xmlInfo;

	private List<EmotionCardAbilityBase> _abilityList;

	public int stack;

	private BattleUnitModel _owner;

	public EmotionCardXmlInfo XmlInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<EmotionCardAbilityBase> AbilityList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitModel Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionCardModel(EmotionCardXmlInfo xmlInfo, BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTypoText(int index, params string[] param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectOnce()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDiceResult(BattleDiceBehavior behavior, ref int diceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_ignoreDead()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_after()
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
	public StatBonus GetStatBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEmotionCoinAdder(int defaultCount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnParryingStart(BattlePlayingCardDataInUnitModel card)
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
	public void OnEnemyRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd_alive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterDiceAction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGiveDeflect(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDiscardByAbility(List<BattleDiceCardModel> cards)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnAddKeywordBufByCard(BattleUnitBuf buf, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnGiveKeywordBufByCard(BattleUnitBuf buf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckDmg(int dmg, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSpeedDiceAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGiveDamageDouble()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTakeDamageDouble()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterRollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFriendTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartCardAction(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnGetEmotionCoin(EmotionCoinType coin)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDie(BattleUnitModel killer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMakeBreakState(BattleUnitModel attacker)
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
	public void OnFixedUpdateInWaitPhase(float delta)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKill(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterGiveDamage(BattleUnitModel target, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanForcelyAggro()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattlePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLayerChanged(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDiceInRecounter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardCostAdder(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetIcon()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbnormalityCard GetAbilityOverlayDescription()
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
	public List<EmotionCardAbilityBase> GetAbilityList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmune(KeywordBuf buf)
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
	public float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float BreakDmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}
}
