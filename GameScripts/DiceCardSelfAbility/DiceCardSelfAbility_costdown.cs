using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_costdown : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEnterCardPhase(BattleUnitModel unit, BattleDiceCardModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_costdown()
	{
		throw null;
	}

	public class BattleDiceCardBuf_costDownCard : BattleDiceCardBuf
	{
		private int _count;

		public override DiceCardBufType bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_costDownCard(int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}
	}
}
