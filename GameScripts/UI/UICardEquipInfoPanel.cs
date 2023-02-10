using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICardEquipInfoPanel : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private UIDetailCardSlot cardslot;

		[Header("Librarians")]
		[SerializeField]
		private CanvasGroup LibrarianRoot;

		[SerializeField]
		private UICustomSelectablePanel selectablePanel_Librarians;

		[SerializeField]
		private List<UICardEquipInfoSlot> infoSlot;

		[SerializeField]
		private List<UICardInfoSephirahIcon> SephirahIcons;

		[SerializeField]
		private GameObject ActiveIconFrame;

		[Header("Books")]
		[SerializeField]
		private CanvasGroup BookRoot;

		[SerializeField]
		private UICustomSelectablePanel selectablePanel_Books;

		[SerializeField]
		private UICustomSelectable selectable_BooksDummy;

		[SerializeField]
		private List<UIBookCardEquipInfoSlot> bookInfoSlots;

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
		private UICustomSelectable UpSelectableObject;

		[SerializeField]
		private UICustomSelectable DownSelectableObject;

		[Header("Tab")]
		[SerializeField]
		private UITabButton LibrarianTab;

		[SerializeField]
		private UITabButton BookTab;

		private UICustomSelectable prevSelectable;

		private TabType currentTab;

		private DiceCardItemModel curCard;

		public SephirahType curSep;

		private bool isDeckEditor;

		private List<BookCardOwnResult> curEquipBooksResult;

		private int curRow;

		public bool isActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenCardEquipInfo(DiceCardItemModel _curCard, bool _isDeckEditor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSephirah(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteCardFrom(UnitDataModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteCardFrom(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBookInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBookInfoListPage(bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotData()
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
		public void OnSelectUpSelectableObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UIBookCardEquipInfoSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseCardEquipInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTabLibrarian()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTabBook()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTabState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianEquipDeckPanel GetCardDeckPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardEquipInfoPanel()
		{
			throw null;
		}
	}
}
