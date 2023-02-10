using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIManualPopup : UIPopup
	{
		private static UIManualPopup _instance;

		[HideInInspector]
		public List<UIManualTitleButton> titleButtons;

		[SerializeField]
		private UIManualTitleButton currentSelectedButton;

		public UIManualContentId currentid;

		[Header("Resources")]
		public Color defaultcolor;

		public Color highlightedColor;

		public Color clickColor;

		[Header("Controller")]
		[SerializeField]
		private GameObject controllerGuide;

		[SerializeField]
		private GameObject controllerReplace;

		public static UIManualPopup instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedTitleButton(UIManualTitleButton slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonTitle(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonSubTitle(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonSubSubTitle(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedButton(int titleid, int subtitleid, int subsubtitleid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButtons(int titleid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenManualButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseManualButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualPopup()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIManualPopup()
		{
			throw null;
		}
	}
}
