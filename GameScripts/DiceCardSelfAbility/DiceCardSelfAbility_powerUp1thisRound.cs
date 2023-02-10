using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_powerUp1thisRound : DiceCardSelfAbilityBase
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
	public override void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_powerUp1thisRound()
	{
		throw null;
	}

	public class PowerUp1thisRoundBuf : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PowerUp1thisRoundBuf()
		{
			throw null;
		}
	}
}
