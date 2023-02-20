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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviour(BattleDiceBehavior behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVanillaDiceFace(int min, int max)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResultDiceFace(int min, int face)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVanillaDiceValue(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResultDiceValue(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufs(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewBufs(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGift(GiftModel gift)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPassiveAbility(PassiveAbilityBase passive)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPassiveAbilityDesc(string desc)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceDestroyed(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbility(BattleEmotionCardModel emotionPassive)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbility(bool activateByResult, BattleEmotionCardModel emotionPassive, int index, ResultOption option = ResultOption.Default, params int[] param)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionAbilityEffect(string resPath)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCreatureAbilityEffect(string resPath, float time = -1f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewCreatureAbilityEffect(string resPath, float time = -1f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyCreatureEffect(CreatureEffect effect)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCreatureEffectSound(string src)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttackEffectFilter(Type filter)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceBehaviourAbility(bool activateByResult, BattleDiceBehavior diceBehaviour, BattleDiceCardModel cardModel)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviourResult(DiceBehaviourResultData result)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeathState(bool isDead)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakState(bool isBreaked)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageGiven(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageTaken(int dmg, int maxValue, BehaviourDetail detail, AtkResist atkResist = AtkResist.Normal)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakDmgGiven(int breakDmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakDmgTaken(int breakDmg, BehaviourDetail detail, AtkResist atkResist)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsBlocked(bool blocked)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredHp(int amount)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredBp(int amount)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentHp(float curHp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentBreakGauge(int breakGauge)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRecoveredLight(int amount)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEmotionCoin(EmotionCoinType coinType, int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufEffect(string src)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSucceedAtkEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSucceedDefEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRolldiceEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAfterActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTakeDamagedEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUseCardEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEndCardActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrintEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrintDamagedEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParam(int param)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CompareDiceBehavioursUI(List<BattleDiceBehaviourUI> behaviours, CompareBehaviourUIType type)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviourDiceResultUI(CompareBehaviourUIType type)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSkip(DiceUITiming timing = DiceUITiming.Start)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceBehaviourUI> GetBehavioursDiceState(CompareBehaviourUIType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentBuf(BattleBufUIDataList bufDataList)
	{
		
	}
}
