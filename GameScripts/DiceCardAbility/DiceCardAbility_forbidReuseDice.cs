using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_forbidReuseDice : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_forbidReuseDice()
	{
		throw null;
	}
}
