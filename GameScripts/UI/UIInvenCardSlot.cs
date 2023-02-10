using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIInvenCardSlot : UIOriginCardSlot, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Header("---Child---")]
		[Space(10f)]
		[Header("Root Panel")]
		[SerializeField]
		private UIInvenCardListScroll listPanel;

		[Header("CardNumberFrame")]
		[SerializeField]
		protected Image img_cardNumberBg;

		[SerializeField]
		protected TextMeshProUGUI txt_cardNumbers;

		[Header("DeckLimited")]
		[SerializeField]
		private GameObject deckLimitRoot;

		[SerializeField]
		private TextMeshProUGUI txt_deckLimit;

		[Header("Detail Button")]
		[SerializeField]
		private UICustomGraphicObject EquipInfoButton;

		[SerializeField]
		private Animator EquipInfoButtonAnim;

		[Header("Empty")]
		[SerializeField]
		protected CanvasGroup cg_LeftPanel;

		[SerializeField]
		public CanvasGroup cg_EmptyFrameRoot;

		private UIINVENCARD_STATE slotState;

		private bool isEmpty;

		public bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmpty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCgLeftPanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshNumbersData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetFrameColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetLinearDodgeColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardEquipInfoButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardEquipInfoPanel GetCardEquipInfoPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenCardSlot()
		{
			throw null;
		}
	}
}
