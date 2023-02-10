using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LOR_Localize
{
	public class BattleCard
	{
		public string cardID;

		public string cardName;

		public List<BattleCardBehaviour> behaviours;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCard()
		{
			throw null;
		}
	}
}
