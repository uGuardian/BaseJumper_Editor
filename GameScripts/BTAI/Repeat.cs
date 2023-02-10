using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Repeat : Block
	{
		public int count;

		private int currentCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Repeat(int count)
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
