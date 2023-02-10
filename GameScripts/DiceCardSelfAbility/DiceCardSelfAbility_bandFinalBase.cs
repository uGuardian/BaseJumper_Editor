using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_bandFinalBase : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustAndReturn()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_bandFinalBase()
	{
		throw null;
	}

	public class BattleUnitBuf_addAfter : BattleUnitBuf
	{
		private int _count;

		private LorId _cardId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_addAfter(LorId cardId, int turnCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}
	}
}
