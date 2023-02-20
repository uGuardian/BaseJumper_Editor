using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISettingInvenEquipPageListSlot : UIOriginEquipPageList, IPointerDownHandler, IEventSystemHandler
	{
		[Header("---Child---")]
		[SerializeField]
		private UISettingEquipPageScrollList listRoot;

		[SerializeField]
		public RectTransform rect;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Image img_IconGlow;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		private TextMeshProUGUI txt_StoryName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_StoryName;

		[SerializeField]
		private Image img_EdgeFrame;

		[SerializeField]
		private Image img_LineFrame;

		private readonly int widthsize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<BookModel> books, UIStoryKeyData storyKey)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetSlotSize(int bookcount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrameColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookModel> ApplyFilterBooksInStory(List<BookModel> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetNextPageSlotSelectable(int currentidx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetUpPageSlotSelectable(int currentidx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetNextFirstSlotSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetPrevLastSlotSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingInvenEquipPageListSlot()
		{
			throw null;
		}
	}
}
