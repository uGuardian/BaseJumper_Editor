using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_cancelChangeEgo : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_cancelChangeEgo()
	{
		throw null;
	}

	public class BattleUnitBuf_cancel : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_cancel()
		{
			throw null;
		}
	}
}
