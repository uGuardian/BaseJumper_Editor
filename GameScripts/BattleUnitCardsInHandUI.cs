using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleUnitCardsInHandUI : MonoBehaviour
{
	[SerializeField]
	private List<BattleDiceCardUI> _cardList;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private GameObject _rootObj;

	[SerializeField]
	private float _xInterval;

	[SerializeField]
	private float _xStartInterval;

	private BattleUnitModel _selectedUnit;

	private BattleUnitModel _hOveredUnit;

	private BattleDiceCardUI _selectedCard;

	public Transform mouseFollowingTransform;

	public UICustomSelectablePanel selectablePanel;

	public GameObject emptyCardObject;

	public Image emptyCardImage;

	public UICustomSelectable emptySelectable;

	private List<BattleDiceCardUI> _activatedCardList;

	public SpeedDiceUI OnPointerOverInSpeedDice;

	public SpeedDiceUI _beforeSelectDice;

	private List<Vector3> TargetPos;

	public const float startAngle = 7f;

	public const float selectedAngle = -3f;

	private float Lerptimer;

	private BattleUnitCardsInHandUI.HandState _handState;

	private bool _initialized;

	[Header("Ego Toggle")]
	[SerializeField]
	private Toggle toggle_ShowEgo;

	[SerializeField]
	private Image toggle_Icon;

	[SerializeField]
	private Image toggle_bg;

	[SerializeField]
	private Image toggle_padIcon;

	private Color color_ToggleBg;

	[SerializeField]
	private Sprite[] sp_toggleSprite;

	public Color color_iconbghigh;

	[SerializeField]
	private RefineHsv hsv_EgoIconHsv;

	[SerializeField]
	private _2dxFX_Liquid egoBgEffect;

	[SerializeField]
	private Animator anim_EgoToggle;

	[SerializeField]
	private Animator anim_EgotogglePressed;

	private bool isOverOnEgoToggle;

	public GameObject rootobj
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitModel SelectedModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitModel HOveredModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitCardsInHandUI.HandState CurrentHandState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCanvas(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardUI> GetCardUIList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHandCardPosToHand(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateListWithReturnAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCardsObject(BattleUnitModel unitModel, bool isClicked = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCardList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFocus()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActivatedCardsDefaultPos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplySelectedCard(BattleUnitModel target, int targetSlot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCardSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSelectedCardUI(BattleDiceCardUI cardUI)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardUI GetSelectedCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deactivate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActivated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Initialize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelDiceSelection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ArrangeCardListInLerp(int count)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ArrangeEmptyCardInLerp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelCardSelection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelUnitSelection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToDefault()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCloseStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEgoButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdYButton(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdCancel(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEgoToggleState(BattleUnitCardsInHandUI.EgoToggleState state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHighlightedToggleInEventTrigger(bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlockOtherUnitsDice(BattleUnitModel selectedUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnblockOtherUnitsDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitCardsInHandUI()
	{
		throw null;
	}

	public enum HandState
	{
		BattleCard,
		EgoCard
	}

	public enum EgoToggleState
	{
		On,
		Off,
		NotExist,
		Hide
	}
}
