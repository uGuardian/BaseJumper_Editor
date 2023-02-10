using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_nothingEgo : DiceCardSelfAbilityBase
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
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_nothingEgo()
	{
		throw null;
	}
}
