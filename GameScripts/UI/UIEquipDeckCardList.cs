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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel unitdata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetCardsData(List<DiceCardItemModel> cards)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptyCardsData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeDeckTab()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDeckLayout()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardSlotByDeck(UIOriginCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardSlotByInven(UIInvenCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCardSlot(UIOriginCardSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InsertCardSlot(UIInvenCardSlot cardslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OnExitWindow()
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
		public UIInvenCardListScroll GetInvenCardList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipDeckCardList()
		{
			throw null;
		}
	}
}
