using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIInvenLeftEquipPageList : UIOriginEquipPageList, IScrollHandler, IEventSystemHandler, IPointerDownHandler
	{
		[Header("---Child---")]
		[Header("Reference")]
		public UIEquipPageInventoryLeftPanel panel;

		[Header("page btns")]
		public Button btn_nextPage;

		public Button btn_prevPage;

		[SerializeField]
		private List<GameObject> upSelectableObjects;

		[SerializeField]
		private List<GameObject> downSelectableObjects;

		private UnitDataModel _selectedUnit;

		private List<BookModel> applyfilterBookModelList;

		private BookModel _currentSelectedBook;

		[HideInInspector]
		public int currentPage;

		private readonly int widthsize;

		public BookModel CurrentSelectedBook
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<BookModel> books, UnitDataModel unit, bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlot(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEquipPageList(int page)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable FindFirstSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable FindCurrentSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UIInvenLeftEquipPageSlot leftclickSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObjet(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenLeftEquipPageList()
		{
			throw null;
		}
	}
}
