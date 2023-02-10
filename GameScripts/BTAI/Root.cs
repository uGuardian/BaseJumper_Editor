using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Root : Block
	{
		public bool isTerminated;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Root()
		{
			throw null;
		}
	}
}
