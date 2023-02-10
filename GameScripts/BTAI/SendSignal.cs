using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BTAI
{
	public class SendSignal : StateMachineBehaviour
	{
		public string signal;

		[Range(0f, 1f)]
		public float time;

		public bool fired;

		private List<WaitForAnimatorSignal> listeners;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetFalse()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Register(Animator animator, string name, WaitForAnimatorSignal node)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendSignal()
		{
			throw null;
		}
	}
}
