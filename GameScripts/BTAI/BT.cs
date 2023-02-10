using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BTAI
{
	public static class BT
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Root Root()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sequence Sequence()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Selector Selector(bool shuffle = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Action RunCoroutine(Func<IEnumerator<BTState>> coroutine)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Action Call(Action fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConditionalBranch If(Func<bool> fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static While While(Func<bool> fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Condition Condition(Func<bool> fn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Repeat Repeat(int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Wait Wait(float seconds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Trigger Trigger(Animator animator, string name, bool set = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static WaitForAnimatorState WaitForAnimatorState(Animator animator, string name, int layer = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SetBool SetBool(Animator animator, string name, bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SetActive SetActive(GameObject gameObject, bool active)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static WaitForAnimatorSignal WaitForAnimatorSignal(Animator animator, string name, string state, int layer = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Terminate Terminate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Log Log(string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RandomSequence RandomSequence(int[] weights = null)
		{
			throw null;
		}
	}
}
