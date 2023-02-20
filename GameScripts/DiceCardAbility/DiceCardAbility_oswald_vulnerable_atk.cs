using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_oswald_vulnerable_atk : DiceCardAbilityBase
{
	private const int _bleed = 1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_oswald_vulnerable_atk()
	{
		throw null;
	}
}
