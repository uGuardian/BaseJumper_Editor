using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_nullifyPowerAtk : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_nullifyPowerAtk()
	{
		throw null;
	}
}
