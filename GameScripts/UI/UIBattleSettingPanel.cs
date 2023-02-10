using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleSettingPanel : UIPanel
	{
		[Header("Reference")]
		[Header("Center Panel")]
		[SerializeField]
		private GameObject CentralUIRoot;

		[SerializeField]
		private TextMeshProUGUI txt_AvailableUnitNumberText;

		[Header("Start Button")]
		[SerializeField]
		private UICustomGraphicObject button_GameStart;

		[SerializeField]
		private Image img_StartButtonFrame;

		[SerializeField]
		private Image img_startButtonHighlightedFrame;

		[SerializeField]
		private Sprite[] sp_StartButtonFrames;

		[Header("Frame")]
		[SerializeField]
		private CanvasGroup cg_NormalFrame;

		[SerializeField]
		private CanvasGroup cg_KeterCompleteOpenFrame;

		[Header("Back Button")]
		public UICustomGraphicObject button_Back;

		[SerializeField]
		private Image img_backbuttonFrame;

		[SerializeField]
		private Sprite[] sp_BackButtonFrames;

		[Header("UpperButton")]
		[SerializeField]
		private CustomButton button_FloorButton;

		[SerializeField]
		private TextMeshProUGUI txt_FloorText;

		[SerializeField]
		private Image img_floorhighlighted;

		[SerializeField]
		private GameObject ob_floorbuttonicon;

		[SerializeField]
		private TextMeshProMaterialSetter setter_floorbutton;

		[SerializeField]
		private CustomButton button_WaveButton;

		[SerializeField]
		private TextMeshProUGUI txt_WaveButtonText;

		[SerializeField]
		private Image img_Wavehighlighted;

		[SerializeField]
		private GameObject ob_wavebuttonicon;

		[SerializeField]
		private TextMeshProMaterialSetter setter_wavebutton;

		[Header("Center Data")]
		[SerializeField]
		private UIBattleSettingWaveList waveList;

		[SerializeField]
		private GameObject SephirahList;

		[SerializeField]
		private List<UISephirahButton> SephirahButtons;

		[SerializeField]
		private RectTransform rect_ArrowImage;

		[SerializeField]
		private Image img_ArrowImage;

		[SerializeField]
		private Animator anim_CenterPanel;

		[SerializeField]
		private Animator anim_availableText;

		[Header("Profile Left Root")]
		[SerializeField]
		private UIBattleSettingLibrarianInfoPanel infoLeftPanel;

		[Header("Profile Right Root")]
		[SerializeField]
		private UIBattleSettingLibrarianInfoPanel infoRightPanel;

		public Image img_enemyTitleIconBg;

		public Image img_enemyTitleIcon;

		[SerializeField]
		private TextMeshProUGUI txt_enemyNametext;

		[SerializeField]
		public Graphic[] graphics_battleframes;

		[SerializeField]
		private TextMeshProMaterialSetter setter_enemyTitle;

		[Header("Edit Panel")]
		[SerializeField]
		private UIBattleSettingEditPanel _editPanel;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel_Center;

		public UICustomSelectable stageSelectable;

		[Header("Lower Canvas")]
		public List<Canvas> canvaslist;

		private SephirahType _sephirah;

		[HideInInspector]
		public UISephirahButton currentSephirahButton;

		[HideInInspector]
		public RectTransform currentDefeatRect;

		private UIEdItButtonState currentEditButtonState;

		private float arrowspeed;

		private bool isWaveOn;

		public List<UICharacterSlot> currentAvailbleUnitslots;

		private Coroutine floorRevealRoutine;

		private Coroutine WaveRevealRoutine;

		[SerializeField]
		private List<GameObject> ControllerGuides;

		[SerializeField]
		private List<GameObject> ControllerReplaces;

		[Header("LightSpread")]
		[SerializeField]
		private AnimationCurve intentsityCurve;

		[SerializeField]
		private AnimationCurve softKneeCurve;

		[SerializeField]
		private AnimationCurve ThresholdCurve;

		[SerializeField]
		private AnimationCurve TimerCurve;

		[Range(0f, 200f)]
		[SerializeField]
		private float MaxBloomIntensity;

		private float lightspreadTimer;

		private bool IsRunningLightSpread;

		public UIBattleSettingLibrarianInfoPanel InfoRightPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIBattleSettingEditPanel EditPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public SephirahType CurrentSephirahType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseEnter(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseExit(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeSephirahButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentSephirahButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextSephirah(UISephirahButton selectedSephirahButton)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISephirahButton FindSephirahButton(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProfileDataByPanelType(UnitDataModel data, UIPanelType panelType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLibrarianProfileData(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyProfileData(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowUnitDataSideFirst()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ArrowProcess(float targetvalue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetArrowImage(RectTransform startslot, RectTransform endslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickWaveButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnterWaveButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitWaveButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFloorButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnterFloorButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitFloorButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowCenterData(bool waveOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonState(bool waveOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAvailibleText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggles()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedToggles(UICharacterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetAvailableMaxState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetAvailableOne()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetAddedBattleUnitValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFloorRevealInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator FloorRevealProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopFloorRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEndButtonAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartWaveRevealInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaveRevealProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopWaveRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBackButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBattleStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEditPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickOpenEditPage(UIBattleSettingEditTap state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCloseEditPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseEditPageForcely()
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
		private void SelectCurrentFloor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftMenuEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isControllerInput)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeFrameByKeterCompleteOpen(bool iscompleteopen)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLightSpread()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator StartLightSpreadProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsRunningTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingPanel()
		{
			throw null;
		}
	}
}
