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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnknown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultInLibrary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScrollSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(UILibrarianEquipInfoSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectList(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetRectMask2D()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			throw null;
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
