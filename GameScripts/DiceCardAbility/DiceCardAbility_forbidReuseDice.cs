using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_forbidReuseDice : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_forbidReuseDice()
	{
		throw null;
	}
}
