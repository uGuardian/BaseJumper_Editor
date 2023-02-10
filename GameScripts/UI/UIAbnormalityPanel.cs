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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewData(UIAbnormalityCardPreviewSlot overslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewData(UIEmotionPassiveCardInven overslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HidePreviewData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangedScrollView()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCardPreviewSlot GetFirstSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityPanel()
		{
			throw null;
		}
	}
}
