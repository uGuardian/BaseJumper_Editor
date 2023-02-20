using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIChangeColorProcess : UICoroutineProcess
	{
		[Header("ChangeColor Param")]
		public Image img_frame;

		public Color startColor;

		public Color EndColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StartProcess()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ChangeColorProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIChangeColorProcess()
		{
			throw null;
		}
	}
}
