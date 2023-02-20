using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_1303011 : PassiveAbilityBase
{
	private const int _protection = 3;

	private const int _loseHPBreak = 100;

	private const int _strBreak = 1;

	private const int _dmgAddedByBleed = 3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1303011()
	{
		throw null;
	}
}
