using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_UC_Atk : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd_inHand(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_UC_Atk()
	{
		throw null;
	}
}
