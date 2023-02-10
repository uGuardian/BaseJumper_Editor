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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<BookModel> books, UnitDataModel unit, bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlot(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEquipPageList(int page)
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UIInvenLeftEquipPageSlot leftclickSlot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int column)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObjet(int column)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenLeftEquipPageList()
		{
			throw null;
		}
	}
}
