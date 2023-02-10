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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<int> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListDetailFilterGroup()
		{
			throw null;
		}
	}
}
