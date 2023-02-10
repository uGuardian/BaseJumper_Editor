using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICustomizePopup : UIPopup
	{
		private static UICustomizePopup _instance;

		[Header("Left Tab")]
		[SerializeField]
		private UICustomizeMainTap mainTap;

		[Header("Center Profile")]
		[SerializeField]
		private UICustomizeProfile profilepanel;

		[Header("Right Panels")]
		public UICustomizeNamePanel namePanel;

		public UICustomizeHairPanel hairPanel;

		public UICustomizeFacePanel facePanel;

		public UICustomizeClothsPanel clothsPanel;

		public UICustomizeScriptPanel scriptPanel;

		[Header("Controller")]
		public UICustomSelectablePanel SelectablePanel_Left;

		public UICustomSelectablePanel SelectablePanel_Right;

		[SerializeField]
		private GameObject ApplyAndCancelRect;

		[SerializeField]
		private GameObject OnlyApplyRect;

		[SerializeField]
		private List<GameObject> ControllerGuides;

		private UnitDataModel _selectedUnit;

		public CustomizingSavedData originData;

		public CustomizingSavedData previewData;

		private CustomizeState currentCustomizeState;

		public static UICustomizePopup Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitDataModel SelectedUnit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitReservedData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateNamePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePortrait()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateScript()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePreview()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanelState(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAllPanels()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReset()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRandom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSave()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel_RightPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizePopup()
		{
			throw null;
		}
	}
}
