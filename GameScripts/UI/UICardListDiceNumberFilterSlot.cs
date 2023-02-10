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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListDiceNumberFilterSlot()
		{
			throw null;
		}
	}
}
