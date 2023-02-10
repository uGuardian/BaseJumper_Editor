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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEvent(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnToTitleAndBattleEnd(bool yes)
		{
			
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
