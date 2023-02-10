using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Sequence : Branch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sequence()
		{
			throw null;
		}
	}
}
