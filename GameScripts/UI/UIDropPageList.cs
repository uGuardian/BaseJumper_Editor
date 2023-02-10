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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDropPageList(List<BookDropResult> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDropPageList()
		{
			throw null;
		}
	}
}
