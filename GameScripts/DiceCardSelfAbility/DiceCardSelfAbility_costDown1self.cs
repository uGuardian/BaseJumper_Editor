using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_costDown1self : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_costDown1self()
	{
		throw null;
	}

	public class CostDownSelfBuf : BattleDiceCardBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CostDownSelfBuf()
		{
			throw null;
		}
	}
}
