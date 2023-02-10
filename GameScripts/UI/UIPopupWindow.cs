using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIPopupWindow : SingletonBehavior<UIPopupWindow>
	{
		[SerializeField]
		private UIOptionWindow _optionWindow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPopupWindow()
		{
			throw null;
		}
	}
}
