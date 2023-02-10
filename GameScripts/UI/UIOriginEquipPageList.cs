using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIOriginEquipPageList : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform rect_slotListRoot;

		[SerializeField]
		protected List<UIOriginEquipPageSlot> equipPageSlotList;

		[SerializeField]
		protected List<BookModel> currentScreenBookModelList;

		public List<UIOriginEquipPageSlot> EquipPageSlotList
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
		public virtual void SetEquipPagesData(List<BookModel> books)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEquipPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginEquipPageList()
		{
			throw null;
		}
	}
}
