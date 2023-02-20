using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICustomizeFacePanel : UICustomPanel
	{
		[Header("References")]
		[SerializeField]
		private UICustomTabsController tabsController;

		[SerializeField]
		private Button leftArrow;

		[SerializeField]
		private UICustomSelectable LeftSelectable;

		[SerializeField]
		private Button rightArrow;

		[SerializeField]
		private UICustomSelectable RightSelectable;

		[SerializeField]
		private List<UICustomizeTripleSlot> FaceSlotList;

		public UICustomSelectable firstSelectable;

		[Header("Color Picker")]
		[SerializeField]
		private CustomHSVColorPicker skinColorPicker;

		[SerializeField]
		private Image currentSkinColor;

		[SerializeField]
		private CustomHSVColorPicker eyeColorPicker;

		[SerializeField]
		private Image currentEyeColor;

		private FaceEditPanelState _currentPanelState;

		private int eyeCount;

		private int eyeListIdx;

		private int browCount;

		private int browListIdx;

		private int mouthCount;

		private int mouthListIdx;

		[HideInInspector]
		public int currentEyeIndex;

		[HideInInspector]
		public int currentBrowIndex;

		[HideInInspector]
		public int currentMouthIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFacePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEyePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBrowPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateMouthPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeTab()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitColorPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FaceColorUpdated()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EyeColorUpdated()
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
		public void OnSelectLeftSelectableObject()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeFacePanel()
		{
			throw null;
		}
	}
}
