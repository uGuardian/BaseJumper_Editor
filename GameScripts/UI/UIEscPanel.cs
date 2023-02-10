using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIEscPanel : UIPopup
	{
		public UICustomGraphicObject[] buttons;

		public GameObject exitButton;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEvent(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnToTitleAndBattleEnd(bool yes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEscPanel()
		{
			throw null;
		}

		private enum UIEscButtonType
		{
			Replay,
			Manual,
			Setting,
			ReturnTitle,
			Exit
		}
	}
}
