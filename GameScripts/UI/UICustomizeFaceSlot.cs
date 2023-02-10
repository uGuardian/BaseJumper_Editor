using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICustomizeFaceSlot : UICustomizeLookSlot
	{
		protected UICustomPanel panel;

		public GameObject outterFrame;

		public FaceEditor[] previews;

		private FaceEditPanelState panelState;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeFaceSlot()
		{
			throw null;
		}
	}
}
