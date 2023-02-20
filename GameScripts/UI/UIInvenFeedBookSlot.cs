using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIInvenFeedBookSlot : UIBookSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private UIInvenFeedBookList bookRootListPanel;

		[Header("Base Book")]
		[SerializeField]
		private UICustomGraphicObject plusButton;

		[SerializeField]
		private UICustomGraphicObject minusButton;

		[SerializeField]
		private GameObject bookNumRoot;

		[SerializeField]
		private Image bookNumBg;

		[SerializeField]
		private TextMeshProUGUI txt_bookNum;

		[Header("Tutorial")]
		[SerializeField]
		private GameObject ob_tutorialHighlightFrame;

		[HideInInspector]
		public int remainBookNum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBookFeedExit(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData_DropBook(LorId bookId)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRemainNumber(int minusnum)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptyViewSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPlus(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickMinus(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePMButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HidePMButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelEvent(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetHighlighted(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvenFeedBookSlot()
		{
			throw null;
		}
	}
}
