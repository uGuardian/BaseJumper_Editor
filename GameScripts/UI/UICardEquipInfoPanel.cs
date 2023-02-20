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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSephirah(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteCardFrom(UnitDataModel unit)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteCardFrom(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBookInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBookInfoListPage(bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotData()
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
		public void OnSelectUpSelectableObject()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObject()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UIBookCardEquipInfoSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseCardEquipInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTabLibrarian()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickTabBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTabState()
		{
			
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
