using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_nullifyPower : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_nullifyPower()
	{
		throw null;
	}
}
