using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UI
{
	public class CardListDetailFilterData
	{
		public List<RarityFilterDetails> rarityFilterList;

		public List<DiceFilterDetails> diceFilterList;

		public List<BufFilterDetails> bufFilterList;

		public List<AbilityFilterDetails> abilityFilterList;

		public List<DiceCountFilterDetails> diceCountFilterList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardListDetailFilterData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> GetCheckedIndexList(int group)
		{
			throw null;
		}
	}
}
