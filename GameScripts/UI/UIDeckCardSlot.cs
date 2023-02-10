using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIDeckCardSlot : UIOriginCardSlot
	{
		[Header("---Child---")]
		[Space(10f)]
		[Header("Root Panel")]
		[SerializeField]
		private UIDeckCardList listPanel;

		[Header("DeckLimited")]
		[SerializeField]
		private GameObject deckLimitRoot;

		[SerializeField]
		private TextMeshProUGUI txt_deckLimit;

		private bool isLockState;

		public CardEquipState currentState;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotState()
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
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
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
		public UIDeckCardSlot()
		{
			throw null;
		}
	}
}
