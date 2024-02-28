using System;
using System.Collections.Generic;
using Battle.CreatureEffect;
using LOR_DiceSystem;

public class BattleCardTotalResult
{
	public BattlePlayingCardDataInUnitModel playingCard;

	public BattleDiceCardModel usedCard;

	public List<BattleDiceBehavior> usedDiceList = new List<BattleDiceBehavior>();

	public BattleCardBehaviourResult.BehaviourEvent useCardEvent;

	public BattleCardBehaviourResult.BehaviourEvent endCardActionEvent;

	private List<BattleCardBehaviourResult> _behaviourResultList = new List<BattleCardBehaviourResult>();

	private bool _didCardAction;

	public List<BattleDiceBehaviourUI> prevBehaviour = new List<BattleDiceBehaviourUI>();

	public BattleCardTotalResult(BattlePlayingCardDataInUnitModel playingCard)
	{
		this.playingCard = playingCard;
		this.usedCard = ((playingCard != null) ? playingCard.card : null);
	}

	public Queue<BattleCardBehaviourResult> BehaviourResultQueue
	{
		get
		{
			Queue<BattleCardBehaviourResult> queue = new Queue<BattleCardBehaviourResult>();
			foreach (BattleCardBehaviourResult item in this._behaviourResultList)
			{
				queue.Enqueue(item);
			}
			return queue;
		}
	}

	public IList<BattleCardBehaviourResult> BehaviourResultList
	{
		get
		{
			return this._behaviourResultList;
		}
	}

	private BattleCardBehaviourResult _curbehaviourResult
	{
		get
		{
			if (this._behaviourResultList.Count == 0)
			{
				this._behaviourResultList.Add(new BattleCardBehaviourResult());
			}
			return this._behaviourResultList[this._behaviourResultList.Count - 1];
		}
	}

	public BattleCardBehaviourResult CurbehaviourResult
	{
		get
		{
			return this._curbehaviourResult;
		}
	}

	public void InitNextBehaviour()
	{
		this._behaviourResultList.Add(new BattleCardBehaviourResult());
	}

	public void SetBehaviour(BattleDiceBehavior behaviour)
	{
		this._curbehaviourResult.hasBehaviour = (behaviour != null);
		this._curbehaviourResult.behaviourRawData = ((behaviour != null) ? behaviour.behaviourInCard : null);
		this._curbehaviourResult.playingCard = ((behaviour != null) ? behaviour.card : null);
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		BattleDiceCardModel cardModel;
		if (behaviour == null)
		{
			cardModel = null;
		}
		else
		{
			BattlePlayingCardDataInUnitModel card = behaviour.card;
			cardModel = ((card != null) ? card.card : null);
		}
		curbehaviourResult.cardModel = cardModel;
		this._curbehaviourResult.behaviourIdx = ((behaviour == null) ? -1 : behaviour.Index);
		this._curbehaviourResult.behaviour = behaviour;
	}

	public void SetVanillaDiceFace(int min, int max)
	{
		this._curbehaviourResult.vanillaDiceMin = min;
		this._curbehaviourResult.vanillaDiceFace = max;
	}

	public void SetResultDiceFace(int min, int face)
	{
		this._curbehaviourResult.resultDiceMin = min;
		this._curbehaviourResult.resultDiceMax = face;
	}

	public void SetVanillaDiceValue(int value)
	{
		this._curbehaviourResult.vanillaDiceValue = value;
		this._curbehaviourResult.vanillaDiceValueList.Add(value);
	}

	public void SetResultDiceValue(int value)
	{
		this._curbehaviourResult.resultDiceValue = value;
	}

	public void SetBufs(BattleUnitBuf buf)
	{
		if (buf.positiveType == BufPositiveType.Positive)
		{
			this._curbehaviourResult.bufBeforeRoll.Add(buf.bufActivatedName);
			return;
		}
		this._curbehaviourResult.debufBeforeRoll.Add(buf.bufActivatedName);
	}

	public void SetNewBufs(BattleUnitBuf buf)
	{
		if (buf.positiveType == BufPositiveType.Positive)
		{
			this._curbehaviourResult.bufAfterRoll.Add(buf.bufActivatedName);
			this._curbehaviourResult.bufDataAfterRoll.Add(buf);
			return;
		}
		this._curbehaviourResult.debufAfterRoll.Add(buf.bufActivatedName);
		this._curbehaviourResult.bufDataAfterRoll.Add(buf);
	}

	public void SetGift(GiftModel gift)
	{
		this._curbehaviourResult.giftAbilityBeforeRoll.Add(gift.GetName());
	}

	public void SetPassiveAbility(PassiveAbilityBase passive)
	{
		this._curbehaviourResult.bookAbilityAfterRoll.Add(passive.desc);
		this._curbehaviourResult.bookAbilityDataAfterRoll.Add(passive);
	}

	public void SetPassiveAbilityDesc(string desc)
	{
		this._curbehaviourResult.bookAbilityAfterRoll.Add(desc);
	}

	public void SetDiceDestroyed(bool b)
	{
		this._curbehaviourResult.isDestroyed = b;
	}

	public void SetEmotionAbility(BattleEmotionCardModel emotionPassive)
	{
		this._curbehaviourResult.emotionAbilityBeforeRoll.Add(emotionPassive.ToString());
	}

	public void SetEmotionAbility(bool activateByResult, BattleEmotionCardModel emotionPassive, int index, ResultOption option = ResultOption.Default, params int[] param)
	{
		string[] array = new string[param.Length];
		for (int i = 0; i < param.Length; i++)
		{
			if (option == ResultOption.Sign)
			{
				int num = param[i];
				if (num > 0)
				{
					array[i] = "+" + num;
				}
				else
				{
					array[i] = num.ToString();
				}
			}
			else
			{
				array[i] = param[i].ToString();
			}
		}
		string typoText = emotionPassive.GetTypoText(index, array);
		if (typoText == "")
		{
			return;
		}
		if (activateByResult)
		{
			this._curbehaviourResult.emotionAbilityAfterRoll.Add(typoText);
			this._curbehaviourResult.emotionAbilityDataAfterRoll.Add(emotionPassive);
		}
		else
		{
			this._curbehaviourResult.emotionAbilityAfterRoll.Add(typoText);
			this._curbehaviourResult.emotionAbilityDataAfterRoll.Add(emotionPassive);
		}
		if (!this._curbehaviourResult.activatedEmotionCardDictionary.ContainsKey(emotionPassive.XmlInfo.Name))
		{
			this._curbehaviourResult.activatedEmotionCardDictionary.Add(emotionPassive.XmlInfo.Name, emotionPassive);
		}
	}

	public void SetEmotionAbilityEffect(string resPath)
	{
		this._curbehaviourResult.addedAbnormalityEffectList.Add(resPath);
	}

	public void SetCreatureAbilityEffect(string resPath, float time = -1f)
	{
		this._curbehaviourResult.addedCreatureEffectList.Add(new BattleCardBehaviourResult.CreatureEffectInfo
		{
			path = resPath,
			time = time
		});
	}

	public void SetNewCreatureAbilityEffect(string resPath, float time = -1f)
	{
		string path = "New_IllusionCardFX/" + resPath;
		this._curbehaviourResult.addedCreatureEffectList.Add(new BattleCardBehaviourResult.CreatureEffectInfo
		{
			path = path,
			time = time
		});
	}

	public void ApplyCreatureEffect(CreatureEffect effect)
	{
		if (this._curbehaviourResult.creatureEffects.Contains(effect))
		{
			return;
		}
		this._curbehaviourResult.creatureEffects.Add(effect);
	}

	public void SetCreatureEffectSound(string src)
	{
		this._curbehaviourResult.craetureEffectSounds.Add(src);
	}

	public void SetAttackEffectFilter(Type filter)
	{
		this._curbehaviourResult.addedAttackFilterList.Add(filter);
	}

	public void SetDiceBehaviourAbility(bool activateByResult, BattleDiceBehavior diceBehaviour, BattleDiceCardModel cardModel)
	{
		LorId id = cardModel.GetID();
		int num = cardModel.GetBehaviourList().IndexOf(diceBehaviour.behaviourInCard);
		string value = Singleton<BattleCardAbilityDescXmlList>.Instance.GetAbilityDesc(diceBehaviour.behaviourInCard);
		if (string.IsNullOrEmpty(value))
		{
			value = Singleton<BattleCardDescXmlList>.Instance.GetBehaviourDesc(id, num);
		}
		if (activateByResult)
		{
			if (!this._curbehaviourResult.behaviourAbilityAfterRoll.ContainsKey(num))
			{
				this._curbehaviourResult.behaviourAbilityAfterRoll.Add(num, value);
				return;
			}
		}
		else if (!this._curbehaviourResult.behaviourAbilityAfterRoll.ContainsKey(num))
		{
			this._curbehaviourResult.behaviourAbilityAfterRoll.Add(num, value);
		}
	}

	public void SetBehaviourResult(DiceBehaviourResultData result)
	{
		this._curbehaviourResult.diceBehaviourResult = result;
	}

	public void SetDeathState(bool isDead)
	{
		this._curbehaviourResult.isDead = isDead;
	}

	public void SetBreakState(bool isBreaked)
	{
		this._curbehaviourResult.isBreaked = isBreaked;
	}

	public void SetDamageGiven(int dmg)
	{
		this._curbehaviourResult.dmgListGiven.Add(dmg);
	}

	public void SetDamageTaken(int dmg, int maxValue, BehaviourDetail detail, AtkResist atkResist = AtkResist.Normal)
	{
		this._curbehaviourResult.dmgListTaken.Add(new DmgTakenData(detail, dmg, maxValue, atkResist));
	}

	public void SetBreakDmgGiven(int breakDmg)
	{
		this._curbehaviourResult.breakListGiven.Add(breakDmg);
	}

	public void SetBreakDmgTaken(int breakDmg, BehaviourDetail detail, AtkResist atkResist)
	{
		this._curbehaviourResult.breakListTaken.Add(new DmgTakenData(detail, breakDmg, -1, atkResist));
	}

	public void SetIsBlocked(bool blocked)
	{
		this._curbehaviourResult.isBlockedDice = blocked;
	}

	public void SetRecoveredHp(int amount)
	{
		this._curbehaviourResult.recoveredHpList.Add(amount);
	}

	public void SetRecoveredBp(int amount)
	{
		this._curbehaviourResult.recoveredBpList.Add(amount);
	}

	public void SetCurrentHp(float curHp)
	{
		this._curbehaviourResult.curHp = curHp;
	}

	public void SetCurrentBreakGauge(int breakGauge)
	{
		this._curbehaviourResult.curBreakGauge = breakGauge;
	}

	public void SetRecoveredLight(int amount)
	{
		this._curbehaviourResult.recoveredLight += amount;
	}

	public void AddEmotionCoin(EmotionCoinType coinType, int count)
	{
		this._curbehaviourResult.SetEmotionCoinAdded(coinType, count);
	}

	public void AddBufEffect(string src)
	{
		this._curbehaviourResult.AddBufEffect(src);
	}

	public void SetSucceedAtkEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.succeedAtkEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.succeedAtkEvent, e);
	}

	public void SetSucceedDefEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.succeedDefEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.succeedDefEvent, e);
	}

	public void SetRolldiceEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.rolldiceEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.rolldiceEvent, e);
	}

	public void SetAfterActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.afterActionEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.afterActionEvent, e);
	}

	public void SetTakeDamagedEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.takeDamageEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.takeDamageEvent, e);
	}

	public void SetUseCardEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		this.useCardEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(this.useCardEvent, e);
	}

	public void SetEndCardActionEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		this.endCardActionEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(this.endCardActionEvent, e);
	}

	public void SetPrintEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.printAtkEffectEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.printAtkEffectEvent, e);
	}

	public void SetPrintDamagedEffectEvent(BattleCardBehaviourResult.BehaviourEvent e)
	{
		BattleCardBehaviourResult curbehaviourResult = this._curbehaviourResult;
		curbehaviourResult.printDamagedEffectEvent = (BattleCardBehaviourResult.BehaviourEvent)Delegate.Combine(curbehaviourResult.printDamagedEffectEvent, e);
	}

	public void SetParam(int param)
	{
		this._curbehaviourResult.iParam = param;
	}

	public void CompareDiceBehavioursUI(List<BattleDiceBehaviourUI> behaviours, CompareBehaviourUIType type)
	{
		this.prevBehaviour.Clear();
		switch (type)
		{
		case CompareBehaviourUIType.Before:
			this.prevBehaviour.AddRange(this.GetBehavioursDiceState(CompareBehaviourUIType.Start));
			break;
		case CompareBehaviourUIType.End:
		{
			List<BattleDiceBehaviourUI> behavioursDiceState = this.GetBehavioursDiceState(CompareBehaviourUIType.Start);
			this.prevBehaviour.AddRange(behavioursDiceState);
			break;
		}
		}
		using (List<BattleDiceBehaviourUI>.Enumerator enumerator = behaviours.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BattleDiceBehaviourUI b = enumerator.Current;
				if (this.prevBehaviour.Count != 0)
				{
					BattleDiceBehaviourUI battleDiceBehaviourUI = this.prevBehaviour.Find((BattleDiceBehaviourUI x) => x.Index == b.Index);
					if (battleDiceBehaviourUI != null)
					{
						if (battleDiceBehaviourUI.isSkip)
						{
							b.isRemoveInList = true;
						}
						else if (battleDiceBehaviourUI.isDestroyed)
						{
							b.isRemoveInList = true;
						}
					}
				}
			}
		}
		foreach (BattleDiceBehaviourUI item in behaviours.FindAll((BattleDiceBehaviourUI x) => x.isRemoveInList))
		{
			behaviours.Remove(item);
		}
	}

	public void SetBehaviourDiceResultUI(CompareBehaviourUIType type)
	{
		if (this.playingCard.currentBehavior != null)
		{
			List<BattleDiceBehaviourUI> behavioursDiceState = this.GetBehavioursDiceState(type);
			behavioursDiceState.Clear();
			foreach (BattleDiceBehavior be in this.playingCard.cardBehaviorQueue)
			{
				BattleDiceBehaviourUI item = new BattleDiceBehaviourUI(be);
				behavioursDiceState.Add(item);
			}
			this.CompareDiceBehavioursUI(behavioursDiceState, type);
		}
	}

	public void SetSkip(DiceUITiming timing = DiceUITiming.Start)
	{
		List<BattleDiceBehaviourUI> behavioursDiceState = this.GetBehavioursDiceState(CompareBehaviourUIType.Start);
		if (behavioursDiceState != null)
		{
			foreach (BattleDiceBehaviourUI battleDiceBehaviourUI in behavioursDiceState)
			{
				if (battleDiceBehaviourUI.behaviourInCard.Type == BehaviourType.Def || battleDiceBehaviourUI.behaviourInCard.Type == BehaviourType.Standby)
				{
					battleDiceBehaviourUI.isSkip = true;
					battleDiceBehaviourUI.skipTiming = timing;
				}
			}
		}
	}

	public List<BattleDiceBehaviourUI> GetBehavioursDiceState(CompareBehaviourUIType type)
	{
		List<BattleDiceBehaviourUI> result = new List<BattleDiceBehaviourUI>();
		switch (type)
		{
		case CompareBehaviourUIType.Start:
			result = this._curbehaviourResult.currentAllDiceState.StartBehaviours;
			break;
		case CompareBehaviourUIType.Before:
			result = this._curbehaviourResult.currentAllDiceState.BeforeActionBehaviours;
			break;
		case CompareBehaviourUIType.End:
			result = this._curbehaviourResult.currentAllDiceState.EndBehaviours;
			break;
		}
		return result;
	}

	public void SetCurrentBuf(BattleBufUIDataList bufDataList)
	{
		this._curbehaviourResult.bufDataList.bufReadyList.Clear();
		foreach (BattleBufUIData item in bufDataList.bufReadyList)
		{
			this._curbehaviourResult.bufDataList.bufReadyList.Add(item);
		}
		this._curbehaviourResult.bufDataList.bufActivatedList.Clear();
		foreach (BattleBufUIData item2 in bufDataList.bufActivatedList)
		{
			this._curbehaviourResult.bufDataList.bufActivatedList.Add(item2);
		}
	}
}
