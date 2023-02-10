﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleDiceCardUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IEndDragHandler
{
	[Header("Resource")]
	[SerializeField]
	private RectTransform vibeRect;

	[SerializeField]
	private Sprite[] costNumberSprite;

	[Header("Color")]
	[SerializeField]
	private Color[] refColors_Cost;

	[Header("References")]
	public TextMeshProUGUI txt_cardName;

	public Image[] img_Frames;

	public Image[] img_linearDodges;

	public GameObject selfAbilityArea;

	public TextMeshProUGUI txt_selfAbility;

	public List<BattleDiceCard_BehaviourDescUI> ui_behaviourDescList;

	public List<Image> img_behaviourDetatilList;

	public Animator anim;

	public Image img_artwork;

	public Image img_icon;

	public RefineHsv hsv_rangeIcon;

	[SerializeField]
	private RefineHsv hsv_Cost;

	private float _glowElapsedTime;

	[Header("added icons")]
	public BattleDiceCardBufUI[] bufIconListUI;

	[Header("Keyword")]
	public KeywordListUI KeywordListUI;

	[Header("Resist")]
	[SerializeField]
	private List<RefineHsv> hsv_behaviourIcons;

	[SerializeField]
	private List<TextMeshProUGUI> txt_Resist;

	[SerializeField]
	private List<TextMeshProUGUI> txt_bpResist;

	[Header("Frames")]
	[SerializeField]
	private GameObject[] ob_NormalFrames;

	[SerializeField]
	private GameObject[] ob_EgoFrames;

	[Header("Pad")]
	public UICustomSelectable selectable;

	[Header("Other Card")]
	public bool isProfileCard;

	[SerializeField]
	private bool isEmotionSelectedPopup;

	[HideInInspector]
	public Canvas _parentCanvas;

	private Transform mouseTransform;

	private int _defaultIdx;

	private BattleDiceCardModel _cardModel;

	private bool _bClicked;

	private bool _bAvailable;

	private bool _bFirstClicked;

	private bool _bEntered;

	private BattleUnitTargetArrowUI arrow;

	private Color colorFrame;

	private Color colorLineardodge;

	private Color colorLineardodge_deactive;

	public Vector3 scaleOrigin;

	[SerializeField]
	private NumbersData costNumbers;

	private int _cost;

	private int _originCost;

	private bool _editor;

	private bool isRunningVibeCard;

	private float vibeCounter;

	private Vector2 rangeIconOriginPos;

	private Vector2 rangeIconEgoPos;

	private EmotionEgoXmlInfo egoxmldata;

	[Header("Ego Gauge")]
	[SerializeField]
	private GameObject ob_EgoCoolTime;

	[SerializeField]
	private RectTransform rect_Gauge;

	[SerializeField]
	private Image img_Bg;

	[SerializeField]
	private Image img_BgGlow;

	[SerializeField]
	private RefineHsv hsv_bgGlow;

	[SerializeField]
	private Animator anim_gaugebgglow;

	[SerializeField]
	private Graphic[] graphics_EgoLockFrames;

	[SerializeField]
	private RefineHsv[] hsv_EgoLockFrames;

	private bool isEgoCoolTimeLock;

	private readonly float gaugeLength;

	public BattleDiceCardModel CardModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsClicked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsEntered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public EmotionEgoXmlInfo EgoXmlData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EditorMode()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrag(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndDrag(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeCard(float time)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDown(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSubmit(BaseEventData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdCursorEnter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdCursorExit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowDetail()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideDetail()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActivatedObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardUI.ClickableState GetClickableState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayVibeCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClick()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckTargetable(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCard(BattleDiceCardModel cardModel, params BattleDiceCardUI.Option[] options)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEgoCardForPopup(EmotionEgoXmlInfo egoxmlinfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableAddedIcons()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableAddedIcons()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetSiblingIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLinearDodgeColor(bool activated)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLinearDodgeColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFrameColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRangeIconHsv(Vector3 hsvvalue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCostHightlighted(int cost)
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
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPreviewResist(BattleUnitModel targetunit, BattleDiceCardModel parryingCard = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefaultPreviewResistText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEgoCoolTimeGauge()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEgoLock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEgoFrameLockColor(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardUI()
	{
		throw null;
	}

	public enum Option
	{
		HideDiceAbilityInfo
	}

	public enum ClickableState
	{
		CanClick_emotion,
		CanClick,
		CannotClick,
		NotEnoughCost,
		NoTarget
	}
}
