using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public class CreatureBattleResultData
	{
		public bool isWin;

		public SephirahType battleSephirah;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureBattleResultData()
		{
			throw null;
		}
	}
}
