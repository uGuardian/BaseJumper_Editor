﻿using System;
using System.Runtime.CompilerServices;

public class DiceCardPriority_dontUseFirstRound : DiceCardPriorityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetPriorityBonus(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardPriority_dontUseFirstRound()
	{
		throw null;
	}
}
