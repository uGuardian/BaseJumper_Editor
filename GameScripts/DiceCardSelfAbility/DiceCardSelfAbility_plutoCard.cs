using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_plutoCard : DiceCardSelfAbilityBase
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
	public override void OnDiscard(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_plutoCard()
	{
		throw null;
	}
}
