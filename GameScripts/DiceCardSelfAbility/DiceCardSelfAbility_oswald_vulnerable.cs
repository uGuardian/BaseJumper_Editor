using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_oswald_vulnerable : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_oswald_vulnerable()
	{
		throw null;
	}
}
