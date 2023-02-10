using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFloorPanel : UIPanel
	{
		private LibraryFloorModel _floor;

		[Header("Panels")]
		[SerializeField]
		private UIFloorQuestPanel questPanel;

		[SerializeField]
		private UIFloorTitlePanel uititlePanel;

		[SerializeField]
		private UIAbnormalityPanel abPanel;

		[SerializeField]
		private UIEgoCardPanel egoCardPanel;

		[SerializeField]
		private UICustomTabsController tabsController;

		[SerializeField]
		private GameObject abnormalityEgoTap;

		[SerializeField]
		private GameObject onlyAbnormalityTap;

		[Header("Controller")]
		[SerializeField]
		private UICustomSelectablePanel centerSelectablePanel;

		[SerializeField]
		private UICustomSelectable abegoSelectableRoot;

		[SerializeField]
		private GameObject ControllerGuide;

		[Header("FrameImages")]
		[SerializeField]
		public GraphicBundle Frames;

		[SerializeField]
		public GraphicBundle graphic_FrameGlows;

		[SerializeField]
		private TextMeshProUGUI txt_Level;

		[Header("Blue Primary")]
		[SerializeField]
		private GameObject ob_EndBlueBattleRoot;

		[SerializeField]
		private GameObject ob_FloorInitBattleButtonPanel;

		[SerializeField]
		private UICustomSelectable ob_InitBlueBattleButton;

		[SerializeField]
		private TextMeshProUGUI txt_BackButtonText;

		[SerializeField]
		private Image img_lowerBackFrame;

		[SerializeField]
		private Image img_lowerBackButton;

		[SerializeField]
		private Image img_lowerBackOverButton;

		[SerializeField]
		private UICustomGraphicObject button_lower;

		private bool ExistBothAbEgo;

		public static FirstSelectableState firstSelectableState;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCenterSelectableChild(UICustomSelectable child)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckOpenFloor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrameColor(SephirahType targetSephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrameGlowColor(SephirahType targetSep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSetSephirah(SephirahType targetSephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(CreatureBattleResultData d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAbnormalityEgoTabChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent_Slot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent_Root()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndBattleInBlueButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBluePrimaryBattleButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isControllerInput)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftMenuEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorPanel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIFloorPanel()
		{
			throw null;
		}
	}
}
