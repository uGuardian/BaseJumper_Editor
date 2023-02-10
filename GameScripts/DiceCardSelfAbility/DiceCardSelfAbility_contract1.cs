using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_contract1 : DiceCardSelfAbility_contractBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseOtherCard_inHand(BattleUnitModel unit, BattleDiceCardModel self, BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_contract1()
	{
		throw null;
	}
}
