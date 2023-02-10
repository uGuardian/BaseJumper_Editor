using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIRepeatMoveProcess : UICoroutineProcess
	{
		[Header("RepeatMove")]
		[SerializeField]
		private Vector3 LeftPos;

		[SerializeField]
		private Vector3 rightPos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StartProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ChangeProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRepeatMoveProcess()
		{
			throw null;
		}
	}
}
