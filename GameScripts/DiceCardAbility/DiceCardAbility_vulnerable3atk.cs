using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_vulnerable3atk : DiceCardAbilityBase
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
	public DiceCardAbility_vulnerable3atk()
	{
		throw null;
	}
}
