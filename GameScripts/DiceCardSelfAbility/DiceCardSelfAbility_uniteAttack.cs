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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_uniteAttack()
		{
			throw null;
		}
	}
}
