using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAddedFeedBookSlot : UIBookSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private UIAddedFeedBookList bookRootListPanel;

		[SerializeField]
		private GameObject bookNumRoot;

		[SerializeField]
		private Image bookNumBg;

		[SerializeField]
		private TextMeshProUGUI txt_bookNum;

		[HideInInspector]
		public int addedBookNum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData_DropBook(LorId bookId)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddedNumber(int num)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptyViewSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickMinus()
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
		public override void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAddedFeedBookSlot()
		{
			throw null;
		}
	}
}
