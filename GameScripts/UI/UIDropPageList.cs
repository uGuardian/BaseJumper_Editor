using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIDropPageList : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform slotRoot;

		[SerializeField]
		private List<UIGachaSlot> _gachaSlotList;

		public RectTransform content;

		private List<BookDropResult> dropList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDropPageList(List<BookDropResult> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDropPageList()
		{
			throw null;
		}
	}
}
