using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleResult
{
	public BattleUnitView unit;

	public List<ResultData> resultList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleResult(BattleUnitView u, List<ResultData> r)
	{
		throw null;
	}
}
