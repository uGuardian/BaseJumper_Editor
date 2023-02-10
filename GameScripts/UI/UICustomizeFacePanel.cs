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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFacePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEyePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBrowPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateMouthPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeTab()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitColorPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FaceColorUpdated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EyeColorUpdated()
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
		public void OnSelectLeftSelectableObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectRightSelectableObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeFacePanel()
		{
			throw null;
		}
	}
}
