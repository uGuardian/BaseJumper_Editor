using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BTAI
{
	public class WaitForAnimatorState : BTNode
	{
		private Animator animator;

		private int id;

		private int layer;

		private string stateName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaitForAnimatorState(Animator animator, string name, int layer = 0)
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
