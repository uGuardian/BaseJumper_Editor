using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICardListDetailFilterGroup : MonoBehaviour
	{
		[HideInInspector]
		public List<UICardListDetailFilterSlot> detailSlots;

		[SerializeField]
		private RectTransform slotGroup;

		private int groupIndex;

		private UICardListDetailFilterPopup panel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UICardListDetailFilterPopup p, int groupIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<int> data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListDetailFilterGroup()
		{
			throw null;
		}
	}
}
