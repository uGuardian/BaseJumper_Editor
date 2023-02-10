using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class BattleDiceCardModel
{
	private DiceCardXmlInfo _originalXmlData;

	private DiceCardXmlInfo _xmlData;

	private CardDirection _cardDirection;

	private List<BattleDiceCardBuf> _bufList;

	private List<BattleDiceCardModel.CardIcon> _addedIcons;

	private string _iconAdder;

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
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int CurCost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float MaxCooltimeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float CurrentCooltimeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAddedEgoCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxCooltime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentCostMax()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCoolTime(float value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCoolTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReserveExhaust()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopySelf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToOriginalData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LorId GetID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LorId GetTextId()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rarity GetRarity()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGrade()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSpec GetSpec()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExhaustOnUse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFarToNearForMyo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSkin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardSkinType GetSkinType()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSkinHeight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPriority(int speed = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPriorityAdder(int v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPriorityAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentCost(int cost)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOriginCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceBehaviour> GetBehaviourList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetArtworkSrc()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookCategory GetCategory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAddedIcon(string resName, int priority = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAddedIcon(string resName, int priority = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetAddedIcon(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardBuf GetBufWithMostPriority()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOnlyAllyUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetableSelf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetableAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseOtherCard_inHand(BattleUnitModel unit, BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_inHand(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_inHand(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState_inHand(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbilityBase CreateDiceCardSelfAbilityScript()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceBehavior> CreateDiceCardBehaviorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BattleDiceCardModel CreatePlayingCard(DiceCardXmlInfo cardInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasBuf<T>()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBuf(BattleDiceCardBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBuf(BattleDiceCardBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBuf<T>()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardBuf> GetBufList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufWithoutDuplication(BattleDiceCardBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCost(int cost)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCostToZero(bool zero = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattleUnitModel owner, BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDiscard(BattleUnitModel owner, BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnAddKeywordBufByCard(BattleUnitBuf targetBuf, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnGiveKeywordBufByCard(BattleUnitBuf targetBuf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckDestroyedBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		throw null;
	}

	public class CardIcon
	{
		private Sprite _icon;

		private int _priority;

		public Sprite Icon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Priority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardIcon(Sprite spr, int pri)
		{
			throw null;
		}
	}
}
