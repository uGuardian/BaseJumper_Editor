using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_quick1discard : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDiscard(BattleUnitModel unit, BattleDiceCardModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_quick1discard()
	{
		throw null;
	}
}
