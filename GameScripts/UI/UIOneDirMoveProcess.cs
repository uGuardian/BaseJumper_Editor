using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIOneDirMoveProcess : UICoroutineProcess
	{
		[Header("OneDirMove Param")]
		public Vector3 startpos;

		public Vector3 endpos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StartProcess()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator OneDirectionMoveProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOneDirMoveProcess()
		{
			throw null;
		}
	}
}
