using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_contract3 : DiceCardSelfAbility_contractBase
{
	private int _count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWinParrying_inHand(BattleUnitModel unit, BattleDiceCardModel self, BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_contract3()
	{
		throw null;
	}

	public class BattleDiceCardBuf_contractStackCount : BattleDiceCardBuf
	{
		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_contractStackCount(int stack)
		{
			throw null;
		}
	}
}
