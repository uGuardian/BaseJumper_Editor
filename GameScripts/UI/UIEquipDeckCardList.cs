using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIEquipDeckCardList : UIOriginCardList
	{
		[Header("Reference")]
		public UILibrarianEquipDeckPanel rootPanel;

		[Header("MultiDeckSetting")]
		[SerializeField]
		private GameObject multiDeckLayout;

		[SerializeField]
		private UICustomTabsController deckTabsController;

		[Header("DetailSlot")]
		[SerializeField]
		private UIDetailCardSlot detailSlot;

		[SerializeField]
		private Vector3 targetPosForDetailSlot;

		[SerializeField]
		private Vector3 slotDetailOriginScale;

		public float startspeed;

		public float endspeed;

		[Header("AnimationSlot")]
		[SerializeField]
		private UIOriginCardSlot AnimationSlot;

		[SerializeField]
		private Animator animationSlotAnim;

		private float revealSpeed;

		private float revealCount;

		private Vector3 startScale;

		private Vector3 EndScale;

		private bool isRunningRevealDetailSlot;

		public UnitDataModel currentunit;

		public bool changed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel unitdata)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetCardsData(List<DiceCardItemModel> cards)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptyCardsData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshAll()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeDeckTab()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDeckLayout()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardSlotByDeck(UIOriginCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardSlotByInven(UIInvenCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCardSlot(UIOriginCardSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InsertCardSlot(UIInvenCardSlot cardslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OnExitWindow()
		{
			throw null;
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
		public UIInvenCardListScroll GetInvenCardList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipDeckCardList()
		{
			throw null;
		}
	}
}
