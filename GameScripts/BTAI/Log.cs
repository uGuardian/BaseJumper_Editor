using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Log : BTNode
	{
		private string msg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Log(string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}
	}
}
