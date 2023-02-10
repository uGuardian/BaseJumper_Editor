using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public abstract class BTNode
	{
		public abstract BTState Tick();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BTNode()
		{
			throw null;
		}
	}
}
