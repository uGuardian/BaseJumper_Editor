using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;
using LOR_DiceSystem;

public class BattleCardBehaviourResult
{
	public BattleCardBehaviourResult.BehaviourEvent succeedAtkEvent;

	public BattleCardBehaviourResult.BehaviourEvent succeedDefEvent;

	public BattleCardBehaviourResult.BehaviourEvent takeDamageEvent;

	public BattleCardBehaviourResult.BehaviourEvent rolldiceEvent;

	public BattleCardBehaviourResult.BehaviourEvent afterActionEvent;

	public BattleCardBehaviourResult.BehaviourEvent printAtkEffectEvent;

	public BattleCardBehaviourResult.BehaviourEvent printDamagedEffectEvent;

	public BattleCardBehaviourStack currentAllDiceState;

	public BattleBufUIDataList bufDataList;

	public bool hasBehaviour;

	public BattlePlayingCardDataInUnitModel playingCard;

	public BattleDiceBehavior behaviour;

	public BattleDiceCardModel cardModel;

	public DiceBehaviour behaviourRawData;

	public int behaviourIdx;

	public bool isDestroyed;

	public int vanillaDiceFace;

	public int vanillaDiceMin;

	public int recoveredLight;

	public int diceTypeBonus;

	public int vanillaDiceValue;

	public List<int> vanillaDiceValueList;

	public int resultDiceMin;

	public int resultDiceMax;

	public int resultDiceValue;

	public int iParam;

	public List<string> bufBeforeRoll;

	public List<string> bufAfterRoll;

	public List<string> debufBeforeRoll;

	public List<string> debufAfterRoll;

	public List<string> giftAbilityBeforeRoll;

	public List<string> giftAbilityAfterRoll;

	public List<string> emotionAbilityBeforeRoll;

	public List<string> emotionAbilityAfterRoll;

	public Dictionary<string, BattleEmotionCardModel> activatedEmotionCardDictionary;

	public List<string> behaviourAbilityBeforeRoll;

	public Dictionary<int, string> behaviourAbilityAfterRoll;

	public List<string> bookAbilityAfterRoll;

	public DiceBehaviourResultData diceBehaviourResult;

	public bool isDead;

	public bool isBreaked;

	public bool isBlockedDice;

	public List<int> dmgListGiven;

	public List<DmgTakenData> dmgListTaken;

	public List<int> breakListGiven;

	public List<DmgTakenData> breakListTaken;

	public List<int> recoveredHpList;

	public List<int> recoveredBpList;

	public List<string> addedAbnormalityEffectList;

	public List<BattleCardBehaviourResult.CreatureEffectInfo> addedCreatureEffectList;

	public List<CreatureEffect> creatureEffects;

	public List<string> craetureEffectSounds;

	public List<string> _addedBufEffect;

	private List<EmotionCoinType> _emotionCoinAdder;

	public List<Type> addedAttackFilterList;

	public float curHp;

	public int curBreakGauge;

	public bool ignoreDamagedMotion;

	public List<BattleUnitBuf> bufDataAfterRoll;

	public List<BattleEmotionCardModel> emotionAbilityDataAfterRoll;

	public List<PassiveAbilityBase> bookAbilityDataAfterRoll;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFarAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAllAbilityStrings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Queue<BattleEmotionCardModel> GetActivatedEmotionCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityStringsBeforeRoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityStringsAfterRoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EffectTypoData> GetAbilityDataAfterRoll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionCoinAdded(EmotionCoinType coin, int count)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EmotionCoinType> GetAddedEmotionCoins()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufEffect(string src)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAddedBufEffect()
	{
		throw null;
	}

	public delegate void BehaviourEvent();

	public struct CreatureEffectInfo
	{
		public string path;

		public float time;
	}
}
