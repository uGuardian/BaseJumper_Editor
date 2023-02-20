using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_205411 : PassiveAbilityBase
{
	private const int _draw = 6;

	private const int _recoverPP = 2;

	private const int _maxHp = 200;

	private const int _maxBp = 100;

	private const int _speedDiceNum = 2;

	private const int _speedDiceMin = 2;

	private const int _speedDiceMax = 5;

	private const int _startPP = 2;

	private const int _maxPP = 5;

	private const int _childNum = 4;

	private const int _child1ID = 9020542;

	private const int _child2ID = 9020543;

	private List<BattleUnitModel> _childList;

	private bool _recoverBreakOnRoundStart;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxHpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroyed()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChild(int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpec()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeDeck()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_205411()
	{
		throw null;
	}
}
