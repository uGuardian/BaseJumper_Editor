using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BTAI
{
	public class SetBool : BTNode
	{
		private Animator animator;

		private int id;

		private bool value;

		private string triggerName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetBool(Animator animator, string name, bool value)
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
