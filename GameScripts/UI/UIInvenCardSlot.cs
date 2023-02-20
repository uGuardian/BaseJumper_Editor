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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCgLeftPanel(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotState()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshNumbersData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetFrameColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetLinearDodgeColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCardEquipInfoButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardEquipInfoPanel GetCardEquipInfoPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenCardSlot()
		{
			throw null;
		}
	}
}
