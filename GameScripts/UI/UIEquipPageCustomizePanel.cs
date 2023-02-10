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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(List<int> data, bool isWorkshopInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFilterAll()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBookListPage(bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<int> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<int> bookids)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptyList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEquipPageSlotList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWorkshopSlotList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UIEquipPageCustomizeSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterSlot(BookModel bookModel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterSlot(WorkshopSkinData workshopData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeScrollValue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitScrollBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxRow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObject(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToBooklist()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageCustomizePanel()
		{
			throw null;
		}
	}
}
