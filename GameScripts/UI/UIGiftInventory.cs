using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIGiftInventory : MonoBehaviour
	{
		public UILibrarianAppearanceInfoPanel AppearanceInfoPanel;

		[SerializeField]
		private UIGiftInvenSlot EquipedGiftSlot;

		[SerializeField]
		private List<UIGiftInvenSlot> giftSlotList;

		[SerializeField]
		private UICustomSelectable unequipButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private Button upButton;

		[SerializeField]
		private UICustomSelectable upButtonSelectable;

		[SerializeField]
		private Button downButton;

		[SerializeField]
		private UICustomSelectable downButtonSelectable;

		private UnitDataModel _currentUnit;

		private GiftPosition _currentPart;

		private int currentPageIdx;

		private List<GiftModel> giftListData;

		private UIGiftPreviewSlot giftPreview;

		public bool isActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGiftData(UIGiftPreviewSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGiftData(GiftPosition part)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickUnequip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCloseInven()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGiftSlot(UIGiftInvenSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSelectableSlot(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGiftInventory()
		{
			throw null;
		}
	}
}
