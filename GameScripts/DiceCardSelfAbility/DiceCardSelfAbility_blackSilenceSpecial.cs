using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_blackSilenceSpecial : DiceCardSelfAbilityBase
{
	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_blackSilenceSpecial()
	{
		throw null;
	}
}
