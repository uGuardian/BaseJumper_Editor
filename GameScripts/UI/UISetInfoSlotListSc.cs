using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISetInfoSlotListSc : MonoBehaviour
	{
		[SerializeField]
		private Transform slotsParent;

		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private RectTransform rect_scrollContent;

		[SerializeField]
		private List<UILibrarianEquipInfoSlot> _slotList;

		public UICustomSelectable selectable;

		public GameObject ob_viewport;

		private int activatedSlotCount;

		private bool isListSelected;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStatsDataInEquipBook(BookModel Bdata)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnknown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultInLibrary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScrollSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(int value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UILibrarianEquipInfoSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectList(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRectMask2D()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaitDestroyRectMask()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISetInfoSlotListSc()
		{
			throw null;
		}
	}
}
