using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIOriginBookList : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform rect_slotListRoot;

		protected List<UIBookSlot> bookSlotList;

		protected List<LorId> currentScreenBookIdList;

		public List<UIBookSlot> BookSlotList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetBooksData(List<LorId> bookids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateBookList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginBookList()
		{
			throw null;
		}
	}
}
