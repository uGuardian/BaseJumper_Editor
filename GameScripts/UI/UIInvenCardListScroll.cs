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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<DiceCardItemModel> cards, UnitDataModel unitData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetCardsData(List<DiceCardItemModel> cards)
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
		public override void SetEmptyCardsData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshCardSlotsByInven()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardItemModel> GetCurrentPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeScrollValue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerClickOnInventoryCardSlot(UIInvenCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDetailSlotByInventory(UIOriginCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideDetailSlotByInventory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckUpdateDetailSlot(UIInvenCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealDetailSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealDetailSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitScrollBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFilterAll()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			
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
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenCardListScroll()
		{
			throw null;
		}
	}
}
