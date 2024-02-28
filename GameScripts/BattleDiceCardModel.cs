using System;
using System.Collections.Generic;
using LOR_DiceSystem;
using UnityEngine;

public class BattleDiceCardModel
{
	private DiceCardXmlInfo _originalXmlData;

	private DiceCardXmlInfo _xmlData;

	private CardDirection _cardDirection;

	private List<BattleDiceCardBuf> _bufList = new List<BattleDiceCardBuf>();

	private List<BattleDiceCardModel.CardIcon> _addedIcons = new List<BattleDiceCardModel.CardIcon>();

	private string _iconAdder = "";

	private int _costAdder;

	private bool _costZero;

	private int _priorityAdder;

	private int _curCost;

	public bool exhaust;

	public bool temporary;

	public bool costSpended;

	public bool isCopiedCard;

	public BattleUnitModel owner;

	private DiceCardSelfAbilityBase _script;

	private float maxCooltimeValue;

	private float currentCooltimeValue;

	public DiceCardXmlInfo XmlData
	{
		get
		{
			return this._xmlData;
		}
	}

	public int CurCost
	{
		get
		{
			return this._curCost;
		}
	}

	public float MaxCooltimeValue
	{
		get
		{
			return this.maxCooltimeValue;
		}
	}

	public float CurrentCooltimeValue
	{
		get
		{
			return this.currentCooltimeValue;
		}
	}

	public bool CanAddedEgoCard()
	{
		return this.currentCooltimeValue >= this.maxCooltimeValue;
	}

	public void SetMaxCooltime()
	{
		this.maxCooltimeValue = (float)this.XmlData.EgoMaxCooltimeValue;
	}

	public void SetCurrentCostMax()
	{
		this.currentCooltimeValue = this.maxCooltimeValue;
	}

	public void AddCoolTime(float value)
	{
		this.currentCooltimeValue += value;
		if (this.currentCooltimeValue >= this.maxCooltimeValue)
		{
			this.currentCooltimeValue = this.maxCooltimeValue;
		}
	}

	public void ResetCoolTime()
	{
		this.currentCooltimeValue = 0f;
	}

	public void ReserveExhaust()
	{
		this.exhaust = true;
	}

	public void CopySelf()
	{
		this._originalXmlData = this._xmlData;
		this._xmlData = this._originalXmlData.Copy(true);
	}

	public void ResetToOriginalData()
	{
		if (this._originalXmlData != null)
		{
			this._xmlData = this._originalXmlData.Copy(false);
		}
	}

	public string GetName()
	{
		if (LorId.IsModId(this._xmlData.workshopID))
		{
			return this._xmlData.workshopName;
		}
		return Singleton<BattleCardDescXmlList>.Instance.GetCardDesc(this._xmlData.TextId).cardName;
	}

	public LorId GetID()
	{
		return this._xmlData.id;
	}

	public LorId GetTextId()
	{
		return this._xmlData.TextId;
	}

	public Rarity GetRarity()
	{
		return this._xmlData.Rarity;
	}

	public int GetGrade()
	{
		return 1;
	}

	public DiceCardSpec GetSpec()
	{
		return this._xmlData.Spec;
	}

	public bool IsExhaustOnUse()
	{
		return this._xmlData.IsExhaustOnUse();
	}

	public void ChangeFarToNearForMyo()
	{
		if (this._xmlData.Spec.Ranged != CardRange.Far)
		{
			return;
		}
		DiceCardSpec diceCardSpec = this._xmlData.Spec.Copy();
		diceCardSpec.Ranged = CardRange.Near;
		this._xmlData.Spec = diceCardSpec;
		List<DiceBehaviour> list = new List<DiceBehaviour>();
		foreach (DiceBehaviour diceBehaviour in this._xmlData.DiceBehaviourList)
		{
			DiceBehaviour diceBehaviour2 = diceBehaviour.Copy();
			diceBehaviour2.EffectRes = "RCorp_Z";
			list.Add(diceBehaviour2);
		}
		this._xmlData.DiceBehaviourList = list;
	}

	public string GetSkin()
	{
		return this._xmlData.SkinChange;
	}

	public CardSkinType GetSkinType()
	{
		return this._xmlData.SkinChangeType;
	}

	public int GetSkinHeight()
	{
		return this._xmlData.SkinHeight;
	}

	public string GetMap()
	{
		return this._xmlData.MapChange;
	}

	public int GetPriority(int speed = 0)
	{
		int num = this._xmlData.Priority;
		if (this.owner != null && this._xmlData.PriorityScript != "")
		{
			try
			{
				DiceCardPriorityBase diceCardPriorityBase = Singleton<AssemblyManager>.Instance.CreateInstance_DiceCardPriority(this._xmlData.PriorityScript);
				if (diceCardPriorityBase != null)
				{
					num += diceCardPriorityBase.GetPriorityBonus(this.owner);
					if (speed != 0)
					{
						num += diceCardPriorityBase.GetPriorityBonus(this.owner, speed);
					}
				}
				else
				{
					Debug.LogError("script not found : " + this._xmlData.PriorityScript.Trim());
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		return num + this._priorityAdder;
	}

	public void SetPriorityAdder(int v)
	{
		this._priorityAdder = v;
	}

	public int GetPriorityAdder()
	{
		return this._priorityAdder;
	}

	public int GetCost()
	{
		if (this._script != null && this._script.IsFixedCost())
		{
			return this._xmlData.Spec.Cost;
		}
		int num = this._curCost;
		if (this._costZero)
		{
			num = 0;
		}
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList)
		{
			num = battleDiceCardBuf.GetCost(num);
		}
		int num2 = 0;
		if (this.owner != null)
		{
			num2 += this.owner.emotionDetail.GetCardCostAdder(this);
			num2 += this.owner.bufListDetail.GetCardCostAdder(this);
			if (this._script != null)
			{
				num2 += this._script.GetCostAdder(this.owner, this);
			}
		}
		int num3 = num + this._costAdder + num2;
		if (this.owner != null && this._script != null && this._script != null)
		{
			num3 = this._script.GetCostLast(this.owner, this, num3);
		}
		return Mathf.Max(0, num3);
	}

	public void SetCurrentCost(int cost)
	{
		this._curCost = cost;
	}

	public int GetOriginCost()
	{
		return this._xmlData.Spec.Cost;
	}

	public List<DiceBehaviour> GetBehaviourList()
	{
		return this._xmlData.DiceBehaviourList;
	}

	public string GetArtworkSrc()
	{
		return this._xmlData.Artwork;
	}

	public BookCategory GetCategory()
	{
		return this._xmlData.category;
	}

	public void SetAddedIcon(string resName, int priority = 0)
	{
		this._iconAdder = resName;
		Sprite spr = Resources.Load<Sprite>("Sprites/CardAddedIcon/" + resName);
		if (this._addedIcons.Find((BattleDiceCardModel.CardIcon x) => x.Icon == spr) == null)
		{
			BattleDiceCardModel.CardIcon item = new BattleDiceCardModel.CardIcon(spr, priority);
			this._addedIcons.Add(item);
			this._addedIcons.Sort((BattleDiceCardModel.CardIcon x, BattleDiceCardModel.CardIcon y) => y.Priority - x.Priority);
		}
	}

	public void RemoveAddedIcon(string resName, int priority = 0)
	{
		this._iconAdder = resName;
		Sprite spr = Resources.Load<Sprite>("Sprites/CardAddedIcon/" + resName);
		BattleDiceCardModel.CardIcon cardIcon = this._addedIcons.Find((BattleDiceCardModel.CardIcon x) => x.Icon == spr);
		if (cardIcon != null)
		{
			this._addedIcons.Remove(cardIcon);
		}
	}

	public Sprite GetAddedIcon(int idx)
	{
		Sprite result = null;
		if (idx < this._addedIcons.Count)
		{
			result = this._addedIcons[idx].Icon;
		}
		return result;
	}

	public BattleDiceCardBuf GetBufWithMostPriority()
	{
		BattleDiceCardBuf result = null;
		int num = -1;
		int num2 = -1;
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList)
		{
			if (battleDiceCardBuf.Priority > num2)
			{
				num = battleDiceCardBuf.Stack;
				num2 = battleDiceCardBuf.Priority;
				result = battleDiceCardBuf;
			}
			else if (battleDiceCardBuf.Priority == num2 && battleDiceCardBuf.Stack > num)
			{
				num = battleDiceCardBuf.Stack;
				result = battleDiceCardBuf;
			}
		}
		return result;
	}

	public bool IsOnlyAllyUnit()
	{
		return this._script != null && this._script.IsOnlyAllyUnit();
	}

	public bool IsTargetableSelf()
	{
		return this._script != null && this._script.IsTargetableSelf();
	}

	public bool IsTargetableAllUnit()
	{
		return this._script != null && this._script.IsTargetableAllUnit();
	}

	public bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		bool result = true;
		if (this._script != null)
		{
			result = this._script.IsValidTarget(unit, self, targetUnit);
		}
		return result;
	}

	public void OnUseOtherCard_inHand(BattleUnitModel unit, BattlePlayingCardDataInUnitModel curCard)
	{
		if (this._script != null)
		{
			this._script.OnUseOtherCard_inHand(unit, this, curCard);
		}
	}

	public void OnLoseParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		if (this._script != null)
		{
			this._script.OnLoseParrying_inHand(unit, this, behavior);
		}
	}

	public void OnWinParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		if (this._script != null)
		{
			this._script.OnWinParrying_inHand(unit, this, behavior);
		}
	}

	public void OnRoundEnd(BattleUnitModel unit)
	{
		if (this._script != null)
		{
			this._script.OnRoundEnd(unit, this);
		}
	}

	public void OnRoundEnd_inHand(BattleUnitModel unit)
	{
		if (this._script != null)
		{
			this._script.OnRoundEnd_inHand(unit, this);
		}
	}

	public void OnRoundStart_inHand(BattleUnitModel unit)
	{
		if (this._script != null)
		{
			this._script.OnRoundStart_inHand(unit, this);
		}
	}

	public void OnBreakState_inHand(BattleUnitModel unit)
	{
		if (this._script != null)
		{
			this._script.OnBreakState_inHand(unit, this);
		}
	}

	public DiceCardSelfAbilityBase CreateDiceCardSelfAbilityScript()
	{
		return Singleton<AssemblyManager>.Instance.CreateInstance_DiceCardSelfAbility(this._xmlData.Script);
	}

	public List<BattleDiceBehavior> CreateDiceCardBehaviorList()
	{
		List<BattleDiceBehavior> list = new List<BattleDiceBehavior>();
		int num = 0;
		foreach (DiceBehaviour diceBehaviour in this._xmlData.DiceBehaviourList)
		{
			string script = diceBehaviour.Script;
			BattleDiceBehavior battleDiceBehavior = new BattleDiceBehavior();
			battleDiceBehavior.behaviourInCard = diceBehaviour.Copy();
			battleDiceBehavior.SetIndex(num);
			list.Add(battleDiceBehavior);
			if (script != string.Empty)
			{
				DiceCardAbilityBase diceCardAbilityBase = Singleton<AssemblyManager>.Instance.CreateInstance_DiceCardAbility(script);
				if (diceCardAbilityBase != null)
				{
					battleDiceBehavior.AddAbility(diceCardAbilityBase);
				}
				else
				{
					Debug.LogError("");
				}
			}
			num++;
		}
		return list;
	}

	public static BattleDiceCardModel CreatePlayingCard(DiceCardXmlInfo cardInfo)
	{
		BattleDiceCardModel battleDiceCardModel = new BattleDiceCardModel();
		battleDiceCardModel._xmlData = cardInfo.Copy(false);
		battleDiceCardModel._curCost = cardInfo.Spec.Cost;
		battleDiceCardModel._script = battleDiceCardModel.CreateDiceCardSelfAbilityScript();
		return battleDiceCardModel;
	}

	public bool HasBuf<T>()
	{
		return this._bufList.Exists((BattleDiceCardBuf x) => x is T);
	}

	public void AddBuf(BattleDiceCardBuf buf)
	{
		this._bufList.Add(buf);
		buf.Init(this);
	}

	public void RemoveBuf(BattleDiceCardBuf buf)
	{
		if (this._bufList.Contains(buf))
		{
			this._bufList.Remove(buf);
		}
	}

	public void RemoveBuf<T>()
	{
		BattleDiceCardBuf battleDiceCardBuf = this._bufList.Find((BattleDiceCardBuf x) => x is T);
		if (battleDiceCardBuf != null)
		{
			this._bufList.Remove(battleDiceCardBuf);
		}
	}

	public List<BattleDiceCardBuf> GetBufList()
	{
		return new List<BattleDiceCardBuf>(this._bufList);
	}

	public void AddBufWithoutDuplication(BattleDiceCardBuf buf)
	{
		if (buf.bufType != DiceCardBufType.None)
		{
			this._bufList.RemoveAll((BattleDiceCardBuf x) => x.bufType == buf.bufType);
		}
		this.AddBuf(buf);
	}

	public void AddCost(int cost)
	{
		this._costAdder += cost;
	}

	public void SetCostToZero(bool zero = true)
	{
		this._costZero = zero;
	}

	public void OnUseCard(BattleUnitModel owner, BattlePlayingCardDataInUnitModel playingCard)
	{
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				battleDiceCardBuf.OnUseCard(owner);
				battleDiceCardBuf.OnUseCard(owner, playingCard);
			}
		}
		this.CheckDestroyedBuf();
	}

	public void OnDiscard(BattleUnitModel owner, BattleDiceCardModel card)
	{
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				battleDiceCardBuf.OnDiscard(owner, card);
			}
		}
	}

	public int OnAddKeywordBufByCard(BattleUnitBuf targetBuf, int stack)
	{
		int num = 0;
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				num += battleDiceCardBuf.OnAddKeywordBufByCard(targetBuf, stack);
			}
		}
		return num;
	}

	public int OnGiveKeywordBufByCard(BattleUnitBuf targetBuf, int stack, BattleUnitModel target)
	{
		int num = 0;
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				num += battleDiceCardBuf.OnGiveKeywordBufByCard(targetBuf, stack, target);
			}
		}
		return num;
	}

	public void CheckDestroyedBuf()
	{
		List<BattleDiceCardBuf> list = new List<BattleDiceCardBuf>();
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			try
			{
				if (battleDiceCardBuf.IsDestroyed())
				{
					list.Add(battleDiceCardBuf);
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		foreach (BattleDiceCardBuf buf in list)
		{
			this.RemoveBuf(buf);
		}
	}

	public void OnRoundStart()
	{
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				battleDiceCardBuf.OnRoundStart();
			}
		}
		this.CheckDestroyedBuf();
	}

	public void OnDrawCard()
	{
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				battleDiceCardBuf.OnDrawCard();
			}
		}
		this.CheckDestroyedBuf();
	}

	public void OnRoundEnd()
	{
		foreach (BattleDiceCardBuf battleDiceCardBuf in this._bufList.ToArray())
		{
			if (!battleDiceCardBuf.IsDestroyed())
			{
				battleDiceCardBuf.OnRoundEnd();
			}
		}
		this.CheckDestroyedBuf();
	}

	public class CardIcon
	{
		private Sprite _icon;

		private int _priority;

		public Sprite Icon
		{
			get
			{
				return this._icon;
			}
		}

		public int Priority
		{
			get
			{
				return this._priority;
			}
		}

		public CardIcon(Sprite spr, int pri)
		{
			this._icon = spr;
			this._priority = pri;
		}
	}
}
