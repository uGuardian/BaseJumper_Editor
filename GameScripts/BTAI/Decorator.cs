using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public abstract class Decorator : BTNode
	{
		protected BTNode child;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Decorator Do(BTNode child)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Decorator()
		{
			throw null;
		}
	}
}
