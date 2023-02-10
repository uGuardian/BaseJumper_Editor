using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICustomizeHairPanel : UICustomPanel
	{
		public UICustomSelectable firstSelectable;

		[Header("Front Hair")]
		[SerializeField]
		private List<UICustomizeSingleSlot> frontHairSlotList;

		[SerializeField]
		private Button frontHairLeftArrow;

		[SerializeField]
		private UICustomSelectable frontHairLeftSelectable;

		[SerializeField]
		private Button frontHairRightArrow;

		[SerializeField]
		private UICustomSelectable frontHairRightSelectable;

		[Header("Back Hair")]
		[SerializeField]
		private List<UICustomizeSingleSlot> backHairSlotList;

		[SerializeField]
		private Button backHairLeftArrow;

		[SerializeField]
		private UICustomSelectable backHairLeftSelectable;

		[SerializeField]
		private Button backHairRightArrow;

		[SerializeField]
		private UICustomSelectable backHairRightSelectable;

		[Header("Color")]
		[SerializeField]
		private Image currentColor;

		[SerializeField]
		private CustomHSVColorPicker colorPicker;

		private int frontHairCount;

		private int frontHairListIdx;

		private int backHairCount;

		private int backHairListIdx;

		[HideInInspector]
		public int currentFrontHairIndex;

		[HideInInspector]
		public int currentBackHairIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFrontHairPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBackHairPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ColorUpdated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitColorPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLook(CustomizingLookType type, UICustomizeLookSlot panel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickArrowButton(int arrow)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLeftSelectableObject_front()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject_front()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLeftSelectableObject_back()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject_back()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeHairPanel()
		{
			throw null;
		}
	}
}
