using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_lowelonly : DiceCardSelfAbilityBase
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_lowelonly()
	{
		throw null;
	}

	public class BattleDiceCardBuf_lowel : BattleDiceCardBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_lowel()
		{
			throw null;
		}
	}
}
