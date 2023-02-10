using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFloorFeedBookPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIAddedFeedBookList addedFeedBookList;

		[SerializeField]
		private TextMeshProUGUI txt_Title;

		[SerializeField]
		private TextMeshProMaterialSetter setter_Title;

		[SerializeField]
		private Graphic[] g_colors;

		[Header("Button")]
		[SerializeField]
		private UICustomGraphicObject button_FeedBook;

		[Header("controller")]
		public UICustomSelectablePanel SelectablePanel;

		private int prevCount;

		private int nextCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFeedBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectValidSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTitle(int addedbooknum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFramesColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractableFeedBookButton(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorFeedBookPanel()
		{
			throw null;
		}
	}
}
