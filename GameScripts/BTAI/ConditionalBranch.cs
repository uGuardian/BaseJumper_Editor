using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class ConditionalBranch : Block
	{
		public Func<bool> fn;

		private bool tested;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConditionalBranch(Func<bool> fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
