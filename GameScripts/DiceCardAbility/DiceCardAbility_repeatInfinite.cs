using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_repeatInfinite : DiceCardAbilityBase
{
	private int _repeatCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_repeatInfinite()
	{
		throw null;
	}
}
