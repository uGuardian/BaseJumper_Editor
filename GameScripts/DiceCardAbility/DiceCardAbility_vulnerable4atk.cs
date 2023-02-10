using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_vulnerable4atk : DiceCardAbilityBase
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
	public override void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_vulnerable4atk()
	{
		throw null;
	}
}
