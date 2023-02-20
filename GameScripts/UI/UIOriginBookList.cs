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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetBooksData(List<LorId> bookids)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateBookList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginBookList()
		{
			throw null;
		}
	}
}
