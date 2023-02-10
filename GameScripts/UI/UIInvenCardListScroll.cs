using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIInvenCardListScroll : UIOriginCardList
	{
		[Header("Child")]
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

		[Header("DetailSlot")]
		[SerializeField]
		private UIDetailCardSlot detailSlot;

		[SerializeField]
		private Vector3 targetPosForDetailSlot;

		[SerializeField]
		private Vector3 slotDetailOriginScale;

		[Header("Filter")]
		public UICardListFilter CardFilter;

		public UIStoryGradeFilter GradeFilter;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel;

		[SerializeField]
		private UnityEvent xEvent;

		[SerializeField]
		private List<UICustomSelectable> UpSelectableObjects;

		[SerializeField]
		private List<UICustomSelectable> DownSelectableObjects;

		protected List<DiceCardItemModel> _originCardList;

		protected List<DiceCardItemModel> _currentCardListForFilter;

		private List<DiceCardItemModel> _disabledCardList;

		[HideInInspector]
		public UIInvenCardSlot currentOverSlot;

		private int curRow;

		private UnitDataModel _unitdata;

		private float revealSpeed;

		private float revealCount;

		private Vector3 startScale;

		private Vector3 EndScale;

		private bool isRunningRevealDetailSlot;

		public float startspeed;

		public float endspeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			throw null;
		}

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
		public void SetData(List<DiceCardItemModel> cards, UnitDataModel unitData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetCardsData(List<DiceCardItemModel> cards)
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
		public override void SetEmptyCardsData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshCardSlotsByInven()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeScrollValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerClickOnInventoryCardSlot(UIInvenCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDetailSlotByInventory(UIOriginCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideDetailSlotByInventory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckUpdateDetailSlot(UIInvenCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealDetailSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealDetailSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
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
		public void ApplyFilterAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCardBySearchFilterUI(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCardsByGradeFilterUI(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCardsByCostFilterUI(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCardsByDetailFilterUI(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToCardList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
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
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenCardListScroll()
		{
			throw null;
		}
	}
}
