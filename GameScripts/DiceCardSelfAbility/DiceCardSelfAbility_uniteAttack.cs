using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_uniteAttack : DiceCardSelfAbilityBase
{
	public override bool IsUniteCard
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_uniteAttack()
	{
		throw null;
	}

	public class BattleUnitBuf_uniteAttack : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_uniteAttack()
		{
			throw null;
		}
	}
}
