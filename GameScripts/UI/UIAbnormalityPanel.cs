using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAbnormalityPanel : MonoBehaviour
	{
		[SerializeField]
		private List<UIAbnormalityCategoryPanel> AbCategoryPanel;

		[Header("Preview Slot")]
		[SerializeField]
		private UIEmotionPassiveCardInven previewCard;

		[Header("ScrollView")]
		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private RectTransform scrollContent;

		[SerializeField]
		private Image LeftButton;

		[SerializeField]
		private Image RightButton;

		private Vector3 targetPosForDetailSlot;

		[Header("Controller")]
		public UnityEvent XEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(LibraryFloorModel floor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewData(UIAbnormalityCardPreviewSlot overslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewData(UIEmotionPassiveCardInven overslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HidePreviewData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangedScrollView()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCardPreviewSlot GetFirstSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityPanel()
		{
			throw null;
		}
	}
}
