using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StoryScene;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

namespace UI
{
	public class UIController : MonoBehaviour
	{
		private static UIController _instance;

		public Camera uiCamera;

		public GameObject Activation_Root;

		public UIItemController _itemController;

		public UIColorManager _colorManager;

		public UIIconManager _iconManager;

		public UISoundManager _soundManager;

		public Image UI_DefaultBackground;

		[Header("Panels")]
		public UIPanel[] Panels;

		public RectTransform PanelRoot;

		public UIPanel[] PanelPrefabs;

		[Header("Sephirah Related")]
		public List<RectTransform> SephirahColoringList;

		[Header("Branch Images")]
		public GameObject BranchImagePivot;

		public List<Image> BattleSettingDisabled;

		public List<Image> BattleSettingEnabled;

		[Header("Transition Related")]
		public GameObject TransitionParticle;

		public Animator FrontCanvasAnimCTRL;

		public UIAnimationEventHandler FrontCanvasEventHandler;

		public float TransitionDelayTime;

		[Header("Particle")]
		public GameObject sepirothBgRoot;

		public GameObject PaperEffectParticleRoot;

		public GameObject DefaultBgRoot;

		public GameObject CenterLensParticle;

		public GameObject LeftLensParticle;

		public GameObject RightLensParticle;

		[Header("PP For Force Cg")]
		public CanvasGroup ForceCg;

		public UIGachaEffect GachaEffectPanel;

		public UIGachaResultPopup GachaPopupPanel;

		public PostProcessVolume p_volume;

		[SerializeField]
		private Canvas postprocessCanvas;

		[SerializeField]
		private Canvas originCanvas;

		[Header("Only Blue Effect")]
		public GameObject ob_BlueEffectAlarmFrame;

		[Header("POPUP UI")]
		[SerializeField]
		private RectTransform rect_PopupParent;

		[SerializeField]
		private UIPopup[] allpopup;

		[SerializeField]
		private Animator anim_LeftBg;

		[SerializeField]
		private Animator anim_RightBg;

		[SerializeField]
		private RectTransform rect_LeftBg;

		[SerializeField]
		private RectTransform rect_RightBg;

		private List<UIPanelType> _allPanels;

		private List<UIPanelType> _currentActivatedPanels;

		private List<UI_SephirahColoring> _sephirahColored;

		private Stack<UIPhase> _uiPhaseStack;

		private UIPhase _currentUIPhase;

		private Queue<UIController.UITransitionInfo> _transitionQueue;

		public Func<bool> onCallUIPhase;

		private UIDataState _uiData;

		private Bloom pp_bloom;

		public bool clickSoundEnable;

		private UIPhase _nextPhase;

		private Action _callback;

		private bool _transition;

		private UIController.UIBGPhase currentstate;

		public static UIController Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static UIItemController ItemController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static UIColorManager ColorManager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static UISoundManager soundManager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static UIIconManager IconManager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<SephirahType> GetOpenedSephirahList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SephirahType GetNextSephirah(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SephirahType GetPreviousSephirah(SephirahType sephirah)
		{
			throw null;
		}

		public Color DefaultColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color HighlightedColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color EnermyColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public event OnUIPhaseEnter PhaseEnterEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		public event OnUIPhaseExit PhaseExitEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		public event OnUIPhaseTransition PhaseTransitionEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		public UIPhase CurrentUIPhase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public SephirahType CurrentSephirah
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public StageClassInfo CurrentStageInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitDataModel CurrentUnit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public ItemModel CurrentItem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitEquipPart CurrentEquipPart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Bloom Pp_Bloom
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
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitPopupPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeForOnlyBattle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPanel GetUIPanel(UIPanelType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreatePopupPanels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPanel CreateUIPanel(UIPanelType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeAllPanels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CleanUpAllPanels()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallUIPhase(int phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallUIPhase_FullTransitionAnim(UIPhase phase, Action callback = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrontCanvasCG(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFrontCanvasDisappeared()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallUIPhase_RevelAnim(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartNextPhaseRevealDelay(float delay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator StopCount(float delay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallUIPhase(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBgState(UIController.UIBGPhase bgstate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBgPosition(UIBgPositionByPhase bgposdata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMainBgAlpah(float alpha)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SepirothUITransition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearUIPhaseStack()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AbortUIPhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadSephirahColoredObjects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSetSephirah(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetSelectedUnit(UnitDataModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStageInfo(StageClassInfo stageInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedEquipPart(UnitEquipPart part)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedItem(ItemModel item)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetCurrentSephirahColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetCurrentSephirah(SephirahType targetSephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBranchImageStatus(bool invitationstatus = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGameStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGameEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefeatForEndContents(EndContentsStageId currenstage, bool inv)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReturnFromEndStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReturnFromEndStoryForKeter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReturnTutorialInviation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenItemList(UnitEquipPart part, ItemModel item, bool isMainUI = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseItemList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartTransition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndTransition(UITransitionHandler handler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayTransitionEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayTransitionEffect(float delay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator DelayTransitionParticle(float time)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseTransition(UIPhase prev, UIPhase next)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenBattlePrepare()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartBattle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BackBattlePrepare()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareBattle(StageClassInfo stageInfo, List<DropBookXmlInfo> selectedBooks)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareBattleBluePrimary(StageClassInfo stageinfo, SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareBattleEndContents(StageClassInfo stageinfo, bool showstartstory, bool save, bool inv, bool ignoreprepareui = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpenStory(string story, StoryRoot.OnEndStoryFunc endFunc, bool skipEnable = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenStory(StageStoryInfo storyInfo, StoryRoot.OnEndStoryFunc endFunc, bool skipEnable = false, bool save = true, bool JustReadStory = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenStory(int chapter, int group, int episode, StoryRoot.OnEndStoryFunc endFunc, bool skipEnable = false, bool save = true, bool JustReadStory = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenBattleResult()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStartCreatureStage(SephirahType targetSephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnterFinalBattle(bool inv = false, bool storySkip = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearActivatePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AllCheckOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveBlueAlarmFrame(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangePanelCanvas(bool ApplyPostprocessing, List<UIPanelType> panels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBloomeIntensity(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBloomSoftKnee(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBloomThreshold(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIController()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIController()
		{
			throw null;
		}

		public class UITransitionInfo
		{
			public List<UITransitionHandler> open_handlers;

			public List<UITransitionHandler> close_handlers;

			private List<UITransitionHandler> _overallList;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UITransitionInfo(ICollection<UITransitionHandler> open, ICollection<UITransitionHandler> closed)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Transition()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool OnCompleted(UITransitionHandler handler)
			{
				throw null;
			}
		}

		public enum UIBGPhase
		{
			None,
			Left,
			Right,
			All
		}
	}
}
