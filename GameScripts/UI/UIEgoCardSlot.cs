using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIEgoCardSlot : UIOriginCardSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private UIEgoCardList listPanel;

		[SerializeField]
		private RefineHsv hsv_egoFrame;

		[SerializeField]
		private GameObject deckLimitRoot;

		[SerializeField]
		private TextMeshProUGUI txt_deckLimit;

		private bool isLock;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetHighlightedSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLock(bool on)
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
		public UIEgoCardSlot()
		{
			throw null;
		}
	}
}
