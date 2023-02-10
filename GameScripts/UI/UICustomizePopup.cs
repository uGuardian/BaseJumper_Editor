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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitReservedData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateNamePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePortrait()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateScript()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePreview()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanelState(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseAllPanels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRandom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSave()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel_RightPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizePopup()
		{
			throw null;
		}
	}
}
