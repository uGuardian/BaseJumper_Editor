using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EnemyUnitTargetSetter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BattleUnitModel SelectTargetUnit(List<BattleUnitModel> candidates)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BattleUnitModel GetHighestAggro(List<BattleUnitModel> candidates)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EnemyUnitTargetSetter CreateTargetSetter(string aiScript)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitTargetSetter()
	{
		throw null;
	}
}
