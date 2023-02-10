using System;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public class RandomSequence : Block
	{
		private int[] m_Weight;

		private int[] m_AddedWeight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RandomSequence(int[] weight = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Branch OpenBranch(params BTNode[] children)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BTState Tick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PickNewChild()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
