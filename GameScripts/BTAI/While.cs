using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class While : Block
	{
		public Func<bool> fn;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public While(Func<bool> fn)
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
