using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class FixedTargetInfo
{
	public BattleUnitModel target;

	public List<int> slots;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixedTargetInfo()
	{
		throw null;
	}
}
