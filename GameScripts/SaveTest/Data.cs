using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SaveTest
{
	[Serializable]
	public class Data
	{
		public string name;

		public Queue<int> num;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Data()
		{
			throw null;
		}
	}
}
