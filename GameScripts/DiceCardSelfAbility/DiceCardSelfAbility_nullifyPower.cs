using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_nullifyPower : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_nullifyPower()
	{
		throw null;
	}
}
