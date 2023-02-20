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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBooksData(List<BookModel> equipbookmodels)
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MovePositionSelectedSlot(RectTransform rectslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator MoveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationCgOff()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipedAnimation(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartUnEquipedAnimation(UIPassiveSuccessionCenterEquipBookSlot bookslot, BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectedPassiveSlot(UIPassiveSuccessionCenterPassiveSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickUnequipBook(UIPassiveSuccessionCenterEquipBookSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterPanel()
		{
			throw null;
		}
	}
}
