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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentCostMax()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCoolTime(float value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCoolTime()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReserveExhaust()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopySelf()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetToOriginalData()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAddedIcon(string resName, int priority = 0)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying_inHand(BattleUnitModel unit, BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_inHand(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_inHand(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState_inHand(BattleUnitModel unit)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBuf(BattleDiceCardBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBuf<T>()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardBuf> GetBufList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBufWithoutDuplication(BattleDiceCardBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCost(int cost)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCostToZero(bool zero = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattleUnitModel owner, BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDiscard(BattleUnitModel owner, BattleDiceCardModel card)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		
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
