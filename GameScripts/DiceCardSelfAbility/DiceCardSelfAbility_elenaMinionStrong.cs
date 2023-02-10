using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_elenaMinionStrong : DiceCardSelfAbilityBase
{
	private bool _successAttack;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_elenaMinionStrong()
	{
		throw null;
	}

	public class BattleUnitBuf_elenaStrongOnce : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_elenaStrongOnce()
		{
			throw null;
		}
	}
}
