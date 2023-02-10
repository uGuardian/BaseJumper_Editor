using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Action : BTNode
	{
		private Action fn;

		private Func<IEnumerator<BTState>> coroutineFactory;

		private IEnumerator<BTState> coroutine;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action(Action fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action(Func<IEnumerator<BTState>> coroutineFactory)
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
