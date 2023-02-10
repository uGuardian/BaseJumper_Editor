using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BTAI
{
	public class Trigger : BTNode
	{
		private Animator animator;

		private int id;

		private string triggerName;

		private bool set;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Trigger(Animator animator, string name, bool set = true)
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
