﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpUI : MonoBehaviour
{
	[SerializeField]
	private float translateSpeed;

	[SerializeField]
	private float translateDelay;

	[SerializeField]
	private Image FloorIconImage;

	[SerializeField]
	private Image ego_FloorIconImage;

	[SerializeField]
	private Image NeedSelectAb_FloorIconImage;

	[SerializeField]
	private GameObject[] LevelTextObjects;

	public CanvasGroup cardSelectionGroup;

	public CanvasGroup cardHidingGroup;

	public CanvasGroup needSelectAbGroup;

	public RectTransform hideTextRect;

	public CanvasGroup textObjectsGroup;

	public RectTransform showTranslator;

	public RawImage img_unitPortraitInHideUI;

	public RawImage img_unitPortraitInShowUI;

	public TextMeshProUGUI txt_unitNameInShowUI;

	public Image selectedEmotionCardBg;

	public EmotionPassiveCardUI selectedEmotionCard;

	public EmotionPassiveCardUI[] candidates;

	public BattleDiceCardUI[] egoSlotList;

	public LevelUpUI_EmotionLvIcon[] _emotionLevels;

	[SerializeField]
	private GameObject ob_AbnormalityLayout;

	[SerializeField]
	private GameObject ob_EgoLayout;

	[SerializeField]
	private GameObject ob_abnormalityCardsPanel;

	[SerializeField]
	private GameObject ob_EgoCardsPanel;

	[SerializeField]
	private TextMeshProUGUI txt_SelectDesc;

	[SerializeField]
	private TextMeshProUGUI txt_BtnSelectDesc;

	[SerializeField]
	private Image img_selectAbBtn;

	[SerializeField]
	private Color[] setBtnColor;

	[SerializeField]
	private Color[] colors_abnormalitytxt;

	[SerializeField]
	private Color[] colors_egotxt;

	[SerializeField]
	private TextMeshProMaterialSetter[] setter_TextColors;

	[SerializeField]
	private _2dxFX_HSV[] hsv_selected;

	[Header("Pad")]
	public UICustomSelectablePanel selectablePanel;

	public UICustomSelectablePanel hideSelectablePanel;

	private BattleUnitModel _model;

	private BattleEffectSound _loopSound;

	private Canvas _canvas;

	private int _curEmotionLvIconIdx;

	private float _elapsedAlarm;

	private bool _bAlarm;

	private bool _needUnitSelection;

	private EmotionCardXmlInfo _selectedCard;

	public bool selectedCard;

	private bool _isEgo;

	private Vector2 _originalNeedSelectionTextPos;

	private TextMeshProUGUI hideText;

	[Header("Emotion Per UI")]
	[SerializeField]
	private GameObject ob_EmotionPerUI;

	[SerializeField]
	private RectTransform rect_BarContent;

	[SerializeField]
	private TextMeshProUGUI txt_PositiveValueText;

	[SerializeField]
	private TextMeshProUGUI txt_NegativeValueText;

	public bool IsEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRootCanvas(bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AlarmSelection()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartStage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(int count, List<EmotionCardXmlInfo> cardList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEgo(int count, List<EmotionEgoXmlInfo> egoList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFocus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitBase(int selectedCount, bool isEgo = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectPassive(EmotionPassiveCardUI picked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnSelectRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickTargetUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DisableRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectEgoCard(BattleDiceCardUI picked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectEgo(EmotionEgoCardUI picked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectHide(bool force = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSelectAb()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickHide()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnXEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnXEvent_show()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectShow()
	{
		throw null;
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
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlinkRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HideRoutine(bool enableDirectly = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ShowRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ShowSelectAbRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HideSelectAbRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator TranslateRoutine(bool hide)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionPerDataUI(float positivevalue, float negativevalue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LevelUpUI()
	{
		throw null;
	}
}
