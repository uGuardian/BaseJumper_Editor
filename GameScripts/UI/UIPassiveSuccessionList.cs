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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipModelData(List<PassiveModel> passives)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedSlot(UIPassiveSuccessionSlot selectedslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionSlot FindSlotByCenterPassive(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipAnimationReveal()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationCgOff()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectedBookSlot(UIPassiveSuccessionSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionList()
		{
			throw null;
		}
	}
}
