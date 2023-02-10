using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_pinochioego : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_pinochioego()
	{
		throw null;
	}

	public class BattleUnitBuf_costAllUp : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCardCostAdder(BattleDiceCardModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_costAllUp()
		{
			throw null;
		}
	}
}
