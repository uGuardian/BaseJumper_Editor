using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIEquipPageScrollList : MonoBehaviour, IScrollHandler, IEventSystemHandler
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private RectTransform rect_slotListRoot;

		[SerializeField]
		private ScrollRect scrollrect_SlotList;

		[SerializeField]
		private List<UIInvenEquipPageListSlot> _equipPagesPanelSlotList;

		[SerializeField]
		private UIBookListSortPanel bookSortFilter;

		[SerializeField]
		private UIStoryGradeFilter GradeFilter;

		[Header("Scroll")]
		public Scrollbar scrollbar;

		public UICustomSelectable scrollbarSelectable;

		public GameObject ob_scorllParent;

		[SerializeField]
		private Image img_Handle;

		[Header("XboxControl")]
		public UICustomSelectablePanel selectablePanel;

		private List<UIOriginEquipPageSlot> allslotlist;

		private UnitDataModel _selectedUnit;

		private List<BookModel> _originBookModelList;

		private List<BookModel> currentBookModelList;

		public BookModel CurrentSelectedBook;

		private List<UIStoryKeyData> currentviewKeyList;

		private List<UIStoryKeyData> totalkeysdata;

		private Dictionary<UIStoryKeyData, List<BookModel>> currentStoryBooksDic;

		private List<UISlotHeightData> heightdatalist;

		private int viewListcount;

		private int currentslotcount;

		private float scrolltotalheight;

		private bool isActiveScrollBar;

		private bool isClickedUpArrow;

		private bool isClickedDownArrow;

		[Range(0.01f, 50f)]
		public float isArrowSpeed;

		[HideInInspector]
		public readonly float titleheight;

		[HideInInspector]
		public readonly float slotLineHeight;

		public float frameoffset;

		[HideInInspector]
		public float slotCountByLine;

		public float offsetContentheight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void scrollUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void scrollDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<BookModel> books, UnitDataModel unit, bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSlotList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateSlotsHeight()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeValueScrollRect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScrollBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownScrollBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDragScrollbar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDragScrollbar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownArrow(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPoinerUpArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeValueScrollBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeBookSort()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookModel> FilterBookModels(List<BookModel> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UIInvenEquipPageSlot leftclickSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckSelectSlotMove(UIOriginEquipPageSlot selectedslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenEquipPageListSlot GetNextListSlot(UIInvenEquipPageListSlot currentslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenEquipPageListSlot GetPrevListSlot(UIInvenEquipPageListSlot currentslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSaveFirstChild(UIOriginEquipPageSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectScrollHandle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectScrollHandle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveChangeBookSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScrollBarNavLeft()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageScrollList()
		{
			throw null;
		}
	}
}
