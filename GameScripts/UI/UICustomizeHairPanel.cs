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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFrontHairPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBackHairPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ColorUpdated()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitColorPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLook(CustomizingLookType type, UICustomizeLookSlot panel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickArrowButton(int arrow)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLeftSelectableObject_front()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject_front()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectLeftSelectableObject_back()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject_back()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeHairPanel()
		{
			throw null;
		}
	}
}
