using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIManualTitleButton : UIManualButtonSlot
	{
		public UIManualPopup panel;

		public List<UIManualSubtitleButton> buttons;

		[HideInInspector]
		public UIManualSubtitleButton currentSelectedButton;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetSelected(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedTitleButton(UIManualSubtitleButton slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualTitleButton()
		{
			throw null;
		}
	}
}
