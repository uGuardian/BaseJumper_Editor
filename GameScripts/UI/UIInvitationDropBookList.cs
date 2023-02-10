using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIInvitationDropBookList : UIOriginBookList
	{
		[SerializeField]
		private UIStoryGradeFilter gradeFilter;

		[Header("---Child---")]
		[SerializeField]
		private CanvasGroup cg;

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

		[HideInInspector]
		public UIBookSlot currentOverSlot;

		public LorId needid;

		private bool activescrolling;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDropBooksData(List<LorId> books, UIInvitationBookSlot parentSlot)
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
		protected override void SetBooksData(List<LorId> bookids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<LorId> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeScrollValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxRow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIInvitationPanel GetInvitationPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
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
		public void OnSelectSlot(UIInvenFeedBookSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitScrollBar()
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
		public void OnCancelEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationDropBookList()
		{
			throw null;
		}
	}
}
