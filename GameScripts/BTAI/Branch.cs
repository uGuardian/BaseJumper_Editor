using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BTAI
{
	public abstract class Branch : BTNode
	{
		protected int activeChild;

		protected List<BTNode> children;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Branch OpenBranch(params BTNode[] children)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BTNode> Children()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ActiveChild()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ResetChildren()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Branch()
		{
			throw null;
		}
	}
}
