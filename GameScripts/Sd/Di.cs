using System;
using System.Runtime.CompilerServices;

namespace Sd
{
	[Serializable]
	public class Di
	{
		public Kv[] li;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Di()
		{
			throw null;
		}
	}
}
