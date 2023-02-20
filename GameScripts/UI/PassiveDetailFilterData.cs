using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UI
{
	public class PassiveDetailFilterData
	{
		public string bookSearchKey;

		public string passiveSearchKey;

		public List<int> costFilterList;

		public List<PassiveFilterDetails> passiveFilterList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveDetailFilterData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> GetCheckedIndexList()
		{
			throw null;
		}
	}
}
