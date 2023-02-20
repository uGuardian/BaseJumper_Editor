using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISettingEquipPageScrollList : MonoBehaviour, IScrollHandler, IEventSystemHandler
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private RectTransform rect_slotListRoot;

		[SerializeField]
		private ScrollRect scrollrect_SlotList;

		[SerializeField]
		private List<UISettingInvenEquipPageListSlot> _equipPagesPanelSlotList;

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

		[Header("Controller")]
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
		public float titleheight;

		[HideInInspector]
		public float slotLineHeight;

		public float frameoffset;

		[HideInInspector]
		public float slotCountByLine;

		public float offsetContentheight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void scrollUp()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void scrollDown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<BookModel> books, UnitDataModel unit, bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSlotList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptySlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapDown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapUp()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateSlotsHeight()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeValueScrollRect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScrollBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownScrollBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDragScrollbar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDragScrollbar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownArrow(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPoinerUpArrow()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeValueScrollBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeBookSort()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookModel> FilterBookModels(List<BookModel> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UISettingInvenEquipPageSlot leftclickSlot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckSelectSlotMove(UIOriginEquipPageSlot selectedslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingInvenEquipPageListSlot GetNextListSlot(UISettingInvenEquipPageListSlot currentslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingInvenEquipPageListSlot GetPrevListSlot(UISettingInvenEquipPageListSlot currentslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSaveFirstChild(UIOriginEquipPageSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectScrollHandle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectScrollHandle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveChangeBookSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScrollBarNavLeft()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageScrollList()
		{
			throw null;
		}
	}
}
