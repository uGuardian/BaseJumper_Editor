using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;
using LOR_DiceSystem;

public class BattleCardTotalResult
{
	public BattlePlayingCardDataInUnitModel playingCard;

	public BattleDiceCardModel usedCard;

	public List<BattleDiceBehavior> usedDiceList;

	public BattleCardBehaviourResult.BehaviourEvent useCardEvent;

	public BattleCardBehaviourResult.BehaviourEvent endCardActionEvent;

	private List<BattleCardBehaviourResult> _behaviourResultList;

	private bool _didCardAction;

	public List<BattleDiceBehaviourUI> prevBehaviour;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCardTotalResult(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	public Queue<BattleCardBehaviourResult> BehaviourResultQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public IList<BattleCardBehaviourResult> BehaviourResultList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BattleCardBehaviourResult _curbehaviourResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleCardBehaviourResult CurbehaviourResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitNextBehaviour()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviour(BattleDiceBehavior behaviour)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVanillaDiceFace(int min, int max)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResultDiceFace(int min, int face)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVanillaDiceValue(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResultDiceValue(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufs(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewBufs(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGift(GiftModel gift)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPassiveAbility(PassiveAbilityBase passive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPassiveAbilityDesc(string desc)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceDestroyed(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbility(BattleEmotionCardModel emotionPassive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbility(bool activateByResult, BattleEmotionCardModel emotionPassive, int index, ResultOption option = ResultOption.Default, params int[] param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbilityEffect(string resPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCreatureAbilityEffect(string resPath, float time = -1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewCreatureAbilityEffect(string resPath, float time = -1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyCreatureEffect(CreatureEffect effect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCreatureEffectSound(string src)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttackEffectFilter(Type filter)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceBehaviourAbility(bool activateByResult, BattleDiceBehavior diceBehaviour, BattleDiceCardModel cardModel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviourResult(DiceBehaviourResultData result)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeathState(bool isDead)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakState(bool isBreaked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageGiven(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageTaken(int dmg, int maxValue, BehaviourDetail detail, AtkResist atkResist = AtkResist.Normal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakDmgGiven(int breakDmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakDmgTaken(int breakDmg, BehaviourDetail detail, AtkResist atkResist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsBlocked(bool blocked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredHp(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredBp(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentHp(float curHp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentBreakGauge(int breakGauge)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredLight(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEmotionCoin(EmotionCoinType coinType, int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufEffect(string src)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSucceedAtkEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSucceedDefEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRolldiceEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAfterActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTakeDamagedEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUseCardEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEndCardActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrintEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrintDamagedEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParam(int param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CompareDiceBehavioursUI(List<BattleDiceBehaviourUI> behaviours, CompareBehaviourUIType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviourDiceResultUI(CompareBehaviourUIType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSkip(DiceUITiming timing = DiceUITiming.Start)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceBehaviourUI> GetBehavioursDiceState(CompareBehaviourUIType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentBuf(BattleBufUIDataList bufDataList)
	{
		throw null;
	}
}
