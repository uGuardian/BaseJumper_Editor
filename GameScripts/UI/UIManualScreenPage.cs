using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIManualScreenPage : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		private const string ScreenShotPath = "Sprites/ManualScreenShot/Origin/";

		[Header("Reference")]
		public UIManualContentPanel panel;

		[Header("ScreenShot")]
		public Image img_screenShot;

		public string screenShotName;

		public UIManualContentId currentid;

		public UIManualContentId nextid;

		private List<UIManualPageofScreenPage> pageList;

		private int currentpage;

		private int maxpage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadContent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetContentImg()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPage(int currentpage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualScreenPage()
		{
			throw null;
		}
	}
}
