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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData eventData)
		{
			
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
		public void SetSelectedTitleButton(UIManualSubsubTitleButton slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualSubtitleButton()
		{
			throw null;
		}
	}
}
