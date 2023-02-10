using System;
using System.Runtime.CompilerServices;

namespace Sd
{
	[Serializable]
	public class Kv
	{
		public string k;

		public object b;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Kv()
		{
			throw null;
		}
	}
}
