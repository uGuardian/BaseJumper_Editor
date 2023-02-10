using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionBookListPanel : MonoBehaviour
	{
		[Header("Reference")]
		public UIPassiveSuccessionPopup panel;

		[SerializeField]
		private List<UIPassiveSuccessionBookSlot> _screenBookSlotList;

		[SerializeField]
		private RectTransform rect_bookslotLayout;

		[Header("Filter")]
		[SerializeField]
		private UIStoryGradeFilter gradeFilterPanel;

		[SerializeField]
		private UIPassiveDetailFilterPanel detailFilter;

		[SerializeField]
		private UICustomGraphicObject detailButton;

		[Header("Preview Panel")]
		[SerializeField]
		private UIPassiveSuccessionPreviewBookPanel previewPanel;

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

		private List<BookModel> _originBookList;

		private List<BookModel> _currentBookList;

		private List<PassiveXmlInfo> _currentPassiveDic;

		[HideInInspector]
		public UIPassiveSuccessionBookSlot currentOverSlot;

		private int curRow;

		private bool slotAnimCondition;

		private float offsetheight;

		[SerializeField]
		private GameObject ob_OtherEquipInfo;

		[SerializeField]
		private Image img_soloBg;

		[SerializeField]
		private Image img_togetherBg;

		[SerializeField]
		private Image img_FloorIcon;

		[SerializeField]
		private GameObject ob_otherEquipUnitData;

		[SerializeField]
		private FaceEditor preivewfaceEdit;

		[SerializeField]
		private TextMeshProUGUI txt_unitName;

		[SerializeField]
		private UICharacterBookSlot equipbookslot;

		private bool isRunningReveal;

		private int currentCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveBooksData(List<BookModel> books)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFilter(bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBookListPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBooksData(List<BookModel> bookids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookModel> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SortProcess(List<BookModel> books)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool EquipBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnEquipBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnequipOtherBook(BookModel book)
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
		public void SetPreviewData(UIPassiveSuccessionBookSlot bookslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPreviewActive(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartAllSameTimeRevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationCgOff()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDetailButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenDetailFilterPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseDetailFilterPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckDetailFilterVaild()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookModel> GetBooksByGradeFilterUI(List<BookModel> books)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookModel> GetBooksBySearchFilterUI(List<BookModel> books)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PassiveXmlInfo> GetPassivesBySearchFilterUI(List<PassiveXmlInfo> passives)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PassiveXmlInfo> GetBooksByCostFilterUI(List<PassiveXmlInfo> passives)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PassiveXmlInfo> GetBooksByKeywordFilterUI(List<PassiveXmlInfo> passives)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsFilterPopupOpened()
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
		public void OnSelectSlot(UIPassiveSuccessionBookSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
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
		public UIPassiveSuccessionBookListPanel()
		{
			throw null;
		}
	}
}
