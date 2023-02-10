using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using Workshop;

namespace UI
{
	public class UIEquipPageCustomizePanel : MonoBehaviour
	{
		public UICustomizeClothsPanel panel;

		[SerializeField]
		private RectTransform rect_slotListRoot;

		protected List<UIEquipPageCustomizeSlot> bookSlotList;

		[SerializeField]
		private UIStoryGradeFilter gradeFilter;

		[Space(10f)]
		[Header("Scroll")]
		[SerializeField]
		private UICustomScrollBar scrollBar;

		[SerializeField]
		private float slotWidth;

		[SerializeField]
		private float slotHeight;

		[SerializeField]
		private int row;

		[SerializeField]
		private int column;

		[Header("controller")]
		public UICustomSelectable ParentSelectable;

		[SerializeField]
		private List<UICustomSelectable> UpSelectableObjects;

		[SerializeField]
		private List<UICustomSelectable> DownSelectableObjects;

		[HideInInspector]
		public bool isWorkshop;

		private List<int> originBookIdList;

		private List<int> filteredBookIdList;

		private List<int> currentScreenBookIdList;

		private int curRow;

		private bool activescrolling;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(List<int> data, bool isWorkshopInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFilterAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBookListPage(bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<int> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<int> bookids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEquipPageSlotList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWorkshopSlotList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UIEquipPageCustomizeSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterSlot(BookModel bookModel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterSlot(WorkshopSkinData workshopData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeScrollValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitScrollBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxRow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObject(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToBooklist()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageCustomizePanel()
		{
			throw null;
		}
	}
}
