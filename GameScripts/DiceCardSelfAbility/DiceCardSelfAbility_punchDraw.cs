using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_punchDraw : DiceCardSelfAbilityBase
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
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_punchDraw()
	{
		throw null;
	}

	public class BattleUnitBuf_punchDraw : BattleUnitBuf
	{
		public BattleDiceCardModel _except;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_punchDraw(BattleDiceCardModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEndTheLast()
		{
			
		}
	}
}
