using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class Wait : BTNode
	{
		public float seconds;

		private float future;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Wait(float seconds)
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
