using System;
using System.Runtime.CompilerServices;

public class DiceCardPriorityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetPriorityBonus(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetPriorityBonus(BattleUnitModel owner, int speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardPriorityBase()
	{
		throw null;
	}
}
