﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIInvenFeedBookList : UIOriginBookList
	{
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
		public UICustomSelectablePanel SelectablePanel;

		[SerializeField]
		private List<UICustomSelectable> UpSelectableObjects;

		[SerializeField]
		private List<UICustomSelectable> DownSelectableObjects;

		private List<LorId> _originBookIdList;

		private List<LorId> _currentBookIdList;

		private int curRow;

		private bool activescrolling;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFeedBooksData(List<LorId> books)
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
		private List<LorId> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetBooksData(List<LorId> bookids)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptyList()
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
		private UIBookPanel GetBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookSlot GetBookSlotById(LorId id)
		{
			throw null;
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
		public void OnSelectSlot(UIInvenFeedBookSlot slot)
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
		public void OnCancel()
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
		public UIInvenFeedBookList()
		{
			throw null;
		}
	}
}
