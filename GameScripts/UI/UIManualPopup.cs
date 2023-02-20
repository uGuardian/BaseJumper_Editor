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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedTitleButton(UIManualTitleButton slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonTitle(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonSubTitle(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonSubSubTitle(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedButton(int titleid, int subtitleid, int subsubtitleid)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButtons(int titleid)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenManualButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseManualButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			
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
