using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIGiftInfoPanel : MonoBehaviour
	{
		[Header("Gift Slots")]
		[SerializeField]
		private RectTransform rect_giftSlotsRoot;

		[SerializeField]
		private List<UIGiftDataSlot> giftSlotList;

		private Color originColor;

		private float plusHeight;

		public float _plusHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(IList<GiftModel> giftlist)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGiftInfoPanel()
		{
			throw null;
		}
	}
}
