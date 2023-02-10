using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class DefenseProbTable
{
	private static Dictionary<int, DefenseProbTable.DefenseProb> advTable;

	private static Dictionary<int, DefenseProbTable.DefenseProb> disadvTable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CoinUsingResult GetDefenseResult(int lvdiff, bool adv)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefenseProbTable()
	{
		throw null;
	}

	private class DefenseProb
	{
		public int bigSuccess;

		public int success;

		public int draw;

		public int fail;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefenseProb(int a, int b, int c, int d)
		{
			throw null;
		}
	}
}
