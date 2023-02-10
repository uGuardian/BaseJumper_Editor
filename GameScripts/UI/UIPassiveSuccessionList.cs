using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionList : MonoBehaviour, IScrollHandler, IEventSystemHandler
	{
		[SerializeField]
		public UIPassiveSuccessionPopup panel;

		[SerializeField]
		public List<UIPassiveSuccessionSlot> slotlist;

		private float minimumheight;

		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private RectTransform rect_scrollContent;

		[SerializeField]
		private RectTransform rect_slotsLayout;

		[SerializeField]
		private UIPassiveSuccessionArrow passiveArrow;

		[SerializeField]
		private UICustomSelectable selectable;

		public UIPassiveSuccessionSlot currentSelctedSlot;

		public bool isEquipList;

		private bool isRunningEquipReveal;

		private int currentEquipCount;

		private bool isRunningReveal;

		private int currentCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipModelData(List<PassiveModel> passives)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedSlot(UIPassiveSuccessionSlot selectedslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionSlot FindSlotByCenterPassive(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipAnimationReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealEquipAnim()
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
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectedBookSlot(UIPassiveSuccessionSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionList()
		{
			throw null;
		}
	}
}
