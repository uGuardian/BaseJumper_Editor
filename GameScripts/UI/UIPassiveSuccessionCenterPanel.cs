using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionCenterPanel : MonoBehaviour
	{
		public UIPassiveSuccessionPopup panel;

		public CanvasGroup cg;

		[SerializeField]
		private RectTransform rect_bookSlotsLayout;

		[SerializeField]
		private List<UIPassiveSuccessionCenterEquipBookSlot> equipBookSlotList;

		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private RectTransform rect_ScrollContent;

		[SerializeField]
		private RectTransform rect_ViewPort;

		public UICustomSelectablePanel selectablePanel;

		[Header("Animation Slot")]
		public UIPassiveSuccessionCenterEquipBookSlot animSlot;

		private int bookListCount;

		public float speed;

		private float movecount;

		private Vector3 targetpos;

		private bool isRunningMove;

		private bool isRunningReveal;

		private int currentCount;

		private float testoffsettime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<BookModel> equipbookmodels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterPassiveSlot GetCenterPassiveSlot(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterEquipBookSlot GetBookSlot(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScrollSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MovePositionSelectedSlot(RectTransform rectslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator MoveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationCgOff()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipedAnimation(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartUnEquipedAnimation(UIPassiveSuccessionCenterEquipBookSlot bookslot, BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectedPassiveSlot(UIPassiveSuccessionCenterPassiveSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickUnequipBook(UIPassiveSuccessionCenterEquipBookSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterPanel()
		{
			throw null;
		}
	}
}
