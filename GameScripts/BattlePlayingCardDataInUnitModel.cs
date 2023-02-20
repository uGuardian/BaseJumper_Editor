using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattlePlayingCardDataInUnitModel
{
	public bool isKeepedCard;

	private bool _bDestroyed;

	public BattleUnitModel owner;

	public BattleUnitModel target;

	public BattleDiceCardModel card;

	public List<BattlePlayingCardDataInUnitModel.SubTarget> subTargets;

	public DiceCardSelfAbilityBase cardAbility;

	public BattleUnitModel earlyTarget;

	public int earlyTargetOrder;

	public int slotOrder;

	public int targetSlotOrder;

	public Queue<BattleDiceBehavior> cardBehaviorQueue;

	public BattleDiceBehavior currentBehavior;

	private List<int> _excludedIndies;

	public BattleDiceBehavior currentBehaviorUI;

	public int speedDiceResultValue;

	public bool isFirstAction;

	public bool ignorePower;

	public int emotionMultiplier;

	private List<BattleUnitModel> _aliveOpponentListOnUse;

	private float _elapsedAttackEnd;

	public bool isDestroyed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattlePlayingCardDataInUnitModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardAffection GetCardAffection()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyPlayingCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceBehavior> GetDiceBehaviorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceBehaviour> GetDiceBehaviourXmlList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceBehaviour> GetOriginalDiceBehaviorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSubTargetToMainTarget()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateActionStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateAttackActionUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ForeachQueue(Predicate<DiceMatch> match, BattlePlayingCardDataInUnitModel.ForeachAction action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int FindOne(Comparison<DiceMatch> comparison, BattlePlayingCardDataInUnitModel.ForeachAction action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int DestroyDice(Predicate<DiceMatch> match, DiceUITiming timing = DiceUITiming.Start)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int DestroyDice(Comparison<DiceMatch> comparison, DiceUITiming timing = DiceUITiming.Start)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddDiceAdder(Predicate<DiceMatch> match, int adder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddDiceMaxValue(Predicate<DiceMatch> match, int adder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddDiceFace(Predicate<DiceMatch> match, int adder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SetDiceEffect(Predicate<DiceMatch> match, DiceEffectType effectType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ApplyDiceStatBonus(Predicate<DiceMatch> match, DiceStatBonus bonus)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ApplyDiceAbility(Predicate<DiceMatch> match, DiceCardAbilityBase ability)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddExcludedDices(List<int> excludedIndies)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetExcludedDices()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCardQueue()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetCardQueueWithoutStandby()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehavior CopyDiceBehaviour(BattleDiceBehavior battleDiceBehavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDice(BattleDiceBehavior diceBehavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDiceFront(BattleDiceBehavior diceBehavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCurBehaviorToQueueFirst()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParryingAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParryingDefense()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDefenseWithoutParryingWin()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard_before()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnActivateResonance()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattleAfterCreateBehaviour()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndAreaAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceBehavior> OnStandbyBehaviour()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartOneSideAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAreaAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRemainingAbilityCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehavior DequeueAbility()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehavior DequeueAbilityTest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NextDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAtkEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedDefEvent()
	{
		
	}

	public delegate void ForeachAction(BattleDiceBehavior ability);

	public class SubTarget
	{
		public BattleUnitModel target;

		public int targetSlotOrder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubTarget()
		{
			
		}
	}
}
