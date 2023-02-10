using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_nosferatu_monster_area : DiceCardAbilityBase
{
	private const int _weak = 2;

	private const int _vuln = 2;

	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAreaAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_nosferatu_monster_area()
	{
		throw null;
	}
}
