using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LOR_DiceSystem
{
	public class SpeedDiceRule
	{
		public int diceNum;

		public int breakedNum;

		public int diceMin;

		public int diceFaces;

		public List<SpeedDice> speedDiceList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeedDiceRule(int min, int face, int num, int breakNum = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<SpeedDice> Roll(BattleUnitModel unitModel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDiceRangeText()
		{
			throw null;
		}
	}
}
