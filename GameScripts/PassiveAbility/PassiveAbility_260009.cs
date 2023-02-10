using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_260009 : PassiveAbilityBase
{
	private const int _weak = 1;

	private const int _paral = 1;

	private const int _bDmg = 2;

	private const int _bRecover = 2;

	private List<PassiveAbility_260009.Ability> available;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Activate(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Activate_Weak(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Activate_Paralysis(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Activate_BreakDmg(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Activate_BreakRecover()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_260009()
	{
		throw null;
	}

	private enum Ability
	{
		Weak,
		Paralysis,
		BreakDmg,
		BreakRecover
	}
}
