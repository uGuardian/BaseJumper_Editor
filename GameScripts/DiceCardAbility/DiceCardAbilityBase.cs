using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class DiceCardAbilityBase
{
	public BattleDiceBehavior behavior;

	public BattlePlayingCardDataInUnitModel card
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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

	public virtual bool Invalidity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool IsPercentDmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public virtual bool IsImmuneDestory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public void ActivateBonusAttackDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<string> GetKeywords()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsDoublePower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeRollDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeRollDice_Target(BattleDiceBehavior targetDice)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMaximumPercentDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAreaAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParrying()
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
	public virtual void OnWinParryingDefense()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAfterAreaAtk(List<BattleUnitModel> damagedList, List<BattleUnitModel> defensedList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbilityBase()
	{
		throw null;
	}

	public enum DiceCardPassiveType
	{
		None,
		RollDice,
		WinParryingAtk,
		WinParryingDfn,
		SuccessAtk,
		AfterAction,
		LoseParrying,
		DrawParrying,
		SuccessDefense,
		BeforeRollDice
	}
}
