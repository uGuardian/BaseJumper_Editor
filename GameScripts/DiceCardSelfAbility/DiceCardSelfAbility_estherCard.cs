using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_estherCard : DiceCardSelfAbilityBase
{
	private bool _dmgGiven;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterGiveDamage(int damage, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_estherCard()
	{
		throw null;
	}
}
