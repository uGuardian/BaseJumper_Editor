using System;
using System.Collections.Generic;
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
		get
		{
			return this._xmlInfo;
		}
	}

	public List<EmotionCardAbilityBase> AbilityList
	{
		get
		{
			return this._abilityList;
		}
	}

	public BattleUnitModel Owner
	{
		get
		{
			return this._owner;
		}
	}

	public BattleEmotionCardModel(EmotionCardXmlInfo xmlInfo, BattleUnitModel owner)
	{
		this._xmlInfo = xmlInfo;
		this._owner = owner;
		this._abilityList = new List<EmotionCardAbilityBase>();
		try
		{
			foreach (string text in xmlInfo.Script)
			{
				EmotionCardAbilityBase emotionCardAbilityBase = Activator.CreateInstance(Type.GetType("EmotionCardAbility_" + text.Trim())) as EmotionCardAbilityBase;
				emotionCardAbilityBase.SetEmotionCard(this);
				this._abilityList.Add(emotionCardAbilityBase);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void SetOwner(BattleUnitModel owner)
	{
		this._owner = owner;
	}

	public string GetTypoText(int index, params string[] param)
	{
		AbnormalityCard abnormalityCard = Singleton<AbnormalityCardDescXmlList>.Instance.GetAbnormalityCard(this._xmlInfo.Name);
		string result = "";
		if (abnormalityCard != null)
		{
			return abnormalityCard.cardName;
		}
		return result;
	}

	public void OnSelect()
	{
		try
		{
			this._owner.UnitData.unitData.history.PickEmotionCard(this);
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnSelectEmotion();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnSelectOnce()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnSelectEmotionOnce();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void ChangeDiceResult(BattleDiceBehavior behavior, ref int diceResult)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.ChangeDiceResult(behavior, ref diceResult);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnDrawCard()
	{
		try
		{
			this._abilityList.ForEach(delegate(EmotionCardAbilityBase x)
			{
				x.OnDrawCard();
			});
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnWaveStart()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnWaveStart();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRoundStart()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRoundStart();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRoundStart_ignoreDead()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRoundStart_ignoreDead();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRoundStart_after()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRoundStart_after();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRoundEnd()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRoundEnd();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRoundEndTheLast()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRoundEndTheLast();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public StatBonus GetStatBonus()
	{
		StatBonus statBonus = new StatBonus();
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				StatBonus statBonus2 = emotionCardAbilityBase.GetStatBonus();
				if (statBonus2 != null)
				{
					statBonus.AddStatBonus(statBonus2);
				}
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return statBonus;
	}

	public int GetEmotionCoinAdder(int defaultCount)
	{
		int result = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		return result;
	}

	public void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnUseCard(card);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnDestroyCard(card);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnParryingStart(BattlePlayingCardDataInUnitModel card)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnParryingStart(card);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void BeforeRollDice(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.BeforeRollDice(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnRollDice(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnRollDice(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnEnemyRollDice(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnEnemyRollDice(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnBattleEnd_alive()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnBattleEnd_alive();
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.BeforeGiveDamage(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void AfterDiceAction(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.AfterDiceAction(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnSucceedAttack(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnWinParrying(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnWinParrying(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnGiveDeflect(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnGiveDeflect(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnLoseParrying(BattleDiceBehavior behavior)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnLoseParrying(behavior);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnDiscardByAbility(List<BattleDiceCardModel> cards)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnDiscardByAbility(cards);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public int OnAddKeywordBufByCard(BattleUnitBuf buf, int stack)
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				num += emotionCardAbilityBase.OnAddKeywordBufByCard(buf, stack);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public int OnGiveKeywordBufByCard(BattleUnitBuf buf, int stack, BattleUnitModel target)
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				num += emotionCardAbilityBase.OnGiveKeywordBufByCard(buf, stack, target);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public void OnDieOtherUnit(BattleUnitModel unit)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnDieOtherUnit(unit);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void CheckDmg(int dmg, BattleUnitModel target)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.CheckDmg(dmg, target);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public int GetSpeedDiceAdder()
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				int speedDiceAdder = emotionCardAbilityBase.GetSpeedDiceAdder();
				num += speedDiceAdder;
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public int GetDamageReduction(BattleDiceBehavior behavior)
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				int damageReduction = emotionCardAbilityBase.GetDamageReduction(behavior);
				num += damageReduction;
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public int GetBreakDamageReduction(BattleDiceBehavior behavior)
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				int breakDamageReduction = emotionCardAbilityBase.GetBreakDamageReduction(behavior);
				num += breakDamageReduction;
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public bool IsGiveDamageDouble()
	{
		bool result = false;
		try
		{
			using (List<EmotionCardAbilityBase>.Enumerator enumerator = this._abilityList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsGiveDamageDouble())
					{
						result = true;
					}
				}
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return result;
	}

	public bool IsTakeDamageDouble()
	{
		bool result = false;
		try
		{
			using (List<EmotionCardAbilityBase>.Enumerator enumerator = this._abilityList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsTakeDamageDouble())
					{
						result = true;
					}
				}
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return result;
	}

	public void OnAfterRollSpeedDice()
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				emotionCardAbilityBase.OnAfterRollSpeedDice();
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
	}

	public void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnTakeDamageByAttack(atkDice, dmg);
		}
	}

	public void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnTakeBreakDamageByAttack(atkDice, dmg);
		}
	}

	public void OnFriendTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnFriendTakeDamageByAttack(atkDice, dmg);
		}
	}

	public void OnStartCardAction(BattlePlayingCardDataInUnitModel curCard)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnStartCardAction(curCard);
		}
	}

	public void OnStartOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnStartOneSideAction(curCard);
		}
	}

	public void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel curCard)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnStartTargetedOneSide(curCard);
		}
	}

	public bool OnGetEmotionCoin(EmotionCoinType coin)
	{
		bool flag = false;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			flag = (emotionCardAbilityBase.OnGetEmotionCoin(coin) || flag);
		}
		return flag;
	}

	public void OnEndParrying(BattlePlayingCardDataInUnitModel curCard)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnEndParrying(curCard);
		}
	}

	public void OnEndOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnEndOneSideAction(curCard);
		}
	}

	public void OnDrawParrying(BattleDiceBehavior behavior)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnDrawParrying(behavior);
		}
	}

	public void OnDie(BattleUnitModel killer)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			emotionCardAbilityBase.OnDie(killer);
		}
	}

	public void OnMakeBreakState(BattleUnitModel attacker)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnMakeBreakState(attacker);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnBreakState()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnBreakState();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnReleaseBreak()
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnReleaseBreak();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnFixedUpdateInWaitPhase(float delta)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnFixedUpdateInWaitPhase(delta);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnKill(BattleUnitModel target)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.OnKill(target);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void AfterGiveDamage(BattleUnitModel target, int dmg)
	{
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				emotionCardAbilityBase.AfterGiveDamage(target, dmg);
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	public bool CanForcelyAggro()
	{
		using (List<EmotionCardAbilityBase>.Enumerator enumerator = this._abilityList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanForcelyAggro())
				{
					return true;
				}
			}
		}
		return false;
	}

	public void OnEndBattlePhase()
	{
		try
		{
			this._abilityList.ForEach(delegate(EmotionCardAbilityBase x)
			{
				x.OnEndBattlePhase();
			});
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnLayerChanged(string layerName)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				emotionCardAbilityBase.OnLayerChanged(layerName);
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
	}

	public void OnRollDiceInRecounter()
	{
		try
		{
			this._abilityList.ForEach(delegate(EmotionCardAbilityBase x)
			{
				x.OnRollDiceInRencounter();
			});
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public void OnBattleEnd()
	{
		try
		{
			this._abilityList.ForEach(delegate(EmotionCardAbilityBase x)
			{
				x.OnBattleEnd();
			});
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	public int GetCardCostAdder(BattleDiceCardModel card)
	{
		int num = 0;
		try
		{
			foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
			{
				num += emotionCardAbilityBase.GetCardCostAdder(card);
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return num;
	}

	public Sprite GetIcon()
	{
		return null;
	}

	public AbnormalityCard GetAbilityOverlayDescription()
	{
		AbnormalityCard result = null;
		try
		{
			result = Singleton<AbnormalityCardDescXmlList>.Instance.GetAbnormalityCard(this.XmlInfo.Name);
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		return result;
	}

	public AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		AtkResist atkResist = origin;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				atkResist = emotionCardAbilityBase.GetResistHP(atkResist, detail);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		return atkResist;
	}

	public AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		AtkResist atkResist = origin;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				atkResist = emotionCardAbilityBase.GetResistBP(atkResist, detail);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		return atkResist;
	}

	public List<EmotionCardAbilityBase> GetAbilityList()
	{
		return this._abilityList;
	}

	public void OnStartBattle()
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				emotionCardAbilityBase.OnStartBattle();
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
	}

	public virtual bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		bool flag = false;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				flag = (emotionCardAbilityBase.BeforeTakeDamage(attacker, dmg) || flag);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		return flag;
	}

	public virtual double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		double num = dmg;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				num = emotionCardAbilityBase.ChangeDamage(attacker, num);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		return num;
	}

	public int MaxPlayPointAdder()
	{
		int num = 0;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				num += emotionCardAbilityBase.MaxPlayPointAdder();
			}
			catch (Exception)
			{
			}
		}
		return num;
	}

	public bool IsImmune(KeywordBuf buf)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				if (emotionCardAbilityBase.IsImmune(buf))
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				if (emotionCardAbilityBase.IsImmuneDmg(type, keyword))
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public bool IsImmuneBreakDmg(DamageType type)
	{
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				if (emotionCardAbilityBase.IsImmuneBreakDmg(type))
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		float num = 1f;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				num *= emotionCardAbilityBase.DmgFactor(dmg, type, keyword);
			}
			catch (Exception)
			{
			}
		}
		return num;
	}

	public float BreakDmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		float num = 1f;
		foreach (EmotionCardAbilityBase emotionCardAbilityBase in this._abilityList)
		{
			try
			{
				num *= emotionCardAbilityBase.BreakDmgFactor(dmg, type, keyword);
			}
			catch (Exception)
			{
			}
		}
		return num;
	}
}
