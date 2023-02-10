using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_immuneDestory : DiceCardAbilityBase
{
	public override bool IsImmuneDestory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_immuneDestory()
	{
		throw null;
	}
}
