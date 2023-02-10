using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIManualSubsubTitleButton : UIManualButtonSlot
	{
		[Header("Parent Panel")]
		public UIManualSubtitleButton panel;

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
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectOnPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualSubsubTitleButton()
		{
			throw null;
		}
	}
}
