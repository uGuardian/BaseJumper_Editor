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
		throw null;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeRollDice_Target(BattleDiceBehavior targetDice)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnRollDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BeforeGiveDamage(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetMaximumPercentDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAreaAttack(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSucceedAttack(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLoseParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnDrawParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinParryingDefense()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AfterAction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnAfterAreaAtk(List<BattleUnitModel> damagedList, List<BattleUnitModel> defensedList)
	{
		throw null;
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
