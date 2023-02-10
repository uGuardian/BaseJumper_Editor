using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_jaeheonPassive : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsOnlyAllyUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_jaeheonPassive()
	{
		throw null;
	}
}
