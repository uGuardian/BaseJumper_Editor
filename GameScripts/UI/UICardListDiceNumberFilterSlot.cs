using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICardListDiceNumberFilterSlot : UIFilterSlot
	{
		[SerializeField]
		protected UICardListDiceNumberFilterPanel panel;

		[HideInInspector]
		public int dicenumber;

		private RectTransform rect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClickToggle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListDiceNumberFilterSlot()
		{
			throw null;
		}
	}
}
