using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleUnitInformationUI : MonoBehaviour
{
	[Header("Setting")]
	[SerializeField]
	private AnimationCurve _alphaCurve;

	[SerializeField]
	private AnimationCurve _yOffsetCurve;

	[SerializeField]
	private float _speed;

	[Header("Resources")]
	[SerializeField]
	private Color colorAlly;

	[SerializeField]
	private Color colorEnemy;

	public Sprite[] numberSprites;

	[Header("Portrait")]
	[SerializeField]
	private RawImage rawImg_portrait;

	[SerializeField]
	private Image img_teamColor;

	[SerializeField]
	private Image img_PortraitFrame;

	[Header("Stats")]
	[SerializeField]
	private TextMeshProUGUI txt_name;

	[SerializeField]
	private TextMeshProUGUI txt_title;

	[Header("Gauge")]
	[SerializeField]
	private RectTransform rect_HpGauge;

	[SerializeField]
	private RectTransform rect_BreakGauge;

	[SerializeField]
	private RectTransform rect_PositiveGauge;

	[SerializeField]
	private RectTransform rect_NegativeGauge;

	[SerializeField]
	private Text txt_Hp;

	[SerializeField]
	private Text txt_Break;

	[SerializeField]
	private Text txt_Emotion;

	[Header("Resists")]
	public List<BattleUnitInformationUI_ResistIcon> hpResists;

	public List<BattleUnitInformationUI_ResistIcon> bpResists;

	public BattleUnitInformationUI_Tooltip tooltip;

	[Header("References")]
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private RectTransform _rootRect;

	[Header("Card Remain Number")]
	[SerializeField]
	private TextMeshProUGUI txt_cardRemainNumber;

	[Header("Buff")]
	[SerializeField]
	private BattleUnitInformationUI_BuffList bufflistmanager;

	[Header("Passive")]
	[SerializeField]
	private BattleUnitInformationUI_PassiveList passivelistManager;

	[SerializeField]
	private Image img_scrollview;

	[Header("Emotion Level")]
	[SerializeField]
	private TextMeshProUGUI txt_lvTitle;

	[SerializeField]
	private GameObject txt_emtionlevellayoutgroup;

	[SerializeField]
	private TextMeshProUGUI txt_LvRome;

	[Header("Preview Card")]
	[SerializeField]
	private BattleCardPreviewSlider cardPreviewSlider;

	[SerializeField]
	private BattleDiceCardUI previewCardUI;

	[Header("AbnormalityCard")]
	[SerializeField]
	private GameObject ob_AbnormalityCardPanel;

	[SerializeField]
	private RectTransform rect_BgFrames;

	[SerializeField]
	private List<EmotionPassiveCardUI> AbnormalityCardList;

	[Space(10f)]
	public Faction faction;

	private BattleUnitModel _currentUnit;

	private bool _hasClickedUnit;

	private BattleUnitModel _clickedUnit;

	private bool _hasClickedDice;

	private BattleUnitModel _clickedUnitByDice;

	private int currentdiceidx;

	[Header("xbox")]
	[SerializeField]
	private UICustomSelectablePanel _statSelectablePanel;

	[SerializeField]
	private UICustomSelectablePanel _abnormalitySelectablePanel;

	[SerializeField]
	private UICustomSelectablePanel _passiveSelectablePanel;

	private BattleDiceCardModel _clickedCard;

	private float _dstAlpha;

	private Vector2 _dstPos;

	private float _elapsed;

	private bool isShowPanel;

	public bool block;

	private List<UICustomSelectableUnitInfoSlot> _statSelectables;

	private Canvas _canvas;

	private bool scrollable;

	public BattleUnitModel ClickedUnitByDice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int CurrentDiceIdx
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UICustomSelectablePanel StatSelectablePanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UICustomSelectablePanel AbnormalitySelectablePanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UICustomSelectablePanel PassivePanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleDiceCardModel clickedCard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool _isShowPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<UICustomSelectableUnitInfoSlot> ConnectedSelectables
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
	public void EnableCanvas(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Canvas GetCanvas()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenUnitInformationBySelectedCard(BattleUnitModel unit, BattleDiceCardModel c, int targetIdx = -1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenUnitInformationByDice(BattleUnitModel unit, bool diceClicked, int diceidx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenUnitInformationByCharacter(BattleUnitModel unit, bool charclicked)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOpenData(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateConnectedSelectables()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseUnitInformationForceByNotClearData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseUnitInformation(bool forcehide, int targetIdx = -1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckShowAbnormalityCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFocus()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSubmit_stat(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSubmit_abnormality(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSubmit_passive(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdButtonY(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdCancel(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReturnToCharterSelection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSelectedCharacter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSelectedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSelectedCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPreviewCard(BattleDiceCardModel card, bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAbnormalityCardList(List<BattleEmotionCardModel> cards)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionLv(int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHp(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBreakLife(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEmotionGauge(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter_Scroll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit_Scroll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Show(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayTooltip(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI()
	{
		throw null;
	}

	private enum BattleInfoState
	{
		None,
		Card,
		EmotionCard
	}

	public class Desc
	{
		public BufPositiveType type;

		public string name;

		public string desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Desc()
		{
			throw null;
		}
	}
}
