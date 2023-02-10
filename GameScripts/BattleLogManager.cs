using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleLogManager : Singleton<BattleLogManager>
{
	private List<BattleLog> battleLog;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleLogManager()
	{
		throw null;
	}
}
