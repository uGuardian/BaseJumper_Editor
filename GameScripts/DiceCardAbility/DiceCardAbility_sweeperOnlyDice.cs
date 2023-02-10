using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_sweeperOnlyDice : DiceCardAbilityBase
{
	private int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_sweeperOnlyDice()
	{
		throw null;
	}
}
