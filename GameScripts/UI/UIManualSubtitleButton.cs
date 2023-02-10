using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIManualSubtitleButton : UIManualButtonSlot
	{
		public UIManualTitleButton panel;

		public List<UIManualSubsubTitleButton> buttons;

		[Header("SubTitle")]
		public RectTransform frame;

		public RectTransform maskFrame;

		private Vector2 originSlotSize;

		private float plusHeight;

		private float frameOffsetHeight;

		private float frameOriginwidth;

		private float maskframeoffsetHeight;

		private float maskframeOriginWidth;

		public UIManualSubsubTitleButton currentSelectedButton;

		public UICustomSelectable selectable;

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
		public void SetSelectedTitleButton(UIManualSubsubTitleButton slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualSubtitleButton()
		{
			throw null;
		}
	}
}
