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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddedNumber(int num)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptyViewSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickMinus()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAddedFeedBookSlot()
		{
			throw null;
		}
	}
}
