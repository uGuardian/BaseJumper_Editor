using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIMainProcessPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private List<UICoroutineProcess> processList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProcess(bool on = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainProcessPanel()
		{
			throw null;
		}
	}
}
