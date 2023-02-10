using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_smallBirdEgo : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_smallBirdEgo()
	{
		throw null;
	}

	public class BattleDiceCardBuf_smallBirdCostDown : BattleDiceCardBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattleUnitModel owner)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_smallBirdCostDown()
		{
			throw null;
		}
	}
}
