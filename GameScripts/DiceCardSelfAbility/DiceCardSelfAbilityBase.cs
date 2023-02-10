using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class DiceCardSelfAbilityBase
{
	public BattlePlayingCardDataInUnitModel card;

	public BattleUnitModel owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool IsUniteCard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTargetChangable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTrueDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAddToHand(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnApplyCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnReleaseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool BeforeAddToHand(BattleUnitModel unit, BattleDiceCardModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartBattleAfterCreateBehaviour()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnterCardPhase(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStartOneSideAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterGiveDamage(int damage, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParryingAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParryingDef()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLoseParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAreaAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollAreaAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEndAreaAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedDefense()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDiscard(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsFixedCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCostLast(BattleUnitModel unit, BattleDiceCardModel self, int oldCost)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetCostAdder(BattleUnitModel unit, BattleDiceCardModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsOnlyAllyUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTargetableSelf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsTargetableAllUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnActivateResonance()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEnd(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseOtherCard_inHand(BattleUnitModel unit, BattleDiceCardModel self, BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLoseParrying_inHand(BattleUnitModel unit, BattleDiceCardModel self, BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParrying_inHand(BattleUnitModel unit, BattleDiceCardModel self, BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundEnd_inHand(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRoundStart_inHand(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBreakState_inHand(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAtkEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedDefEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCardEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsAttackDice(BehaviourDetail diceDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsDefenseDice(BehaviourDetail diceDetail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbilityBase()
	{
		throw null;
	}
}
