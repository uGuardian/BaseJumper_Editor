using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public abstract class Block : Branch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Block()
		{
			throw null;
		}
	}
}
