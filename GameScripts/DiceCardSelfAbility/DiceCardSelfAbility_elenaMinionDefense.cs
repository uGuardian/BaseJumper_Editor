using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_elenaMinionDefense : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_elenaMinionDefense()
	{
		throw null;
	}

	public class BattleUnitBuf_isNotTargetable : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsTargetable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_isNotTargetable()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_elenaMinionDefense : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_elenaMinionDefense()
		{
			throw null;
		}
	}
}
