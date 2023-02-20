using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EmotionPassiveCardUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[Header("Resource")]
	[SerializeField]
	private Sprite[] _negativeBgSprite;

	[SerializeField]
	private Sprite[] _positiveBgSprite;

	[SerializeField]
	private Sprite[] _negativeFrameSprite;

	[SerializeField]
	private Sprite[] _positiveFrameSprite;

	[Header("Reference")]
	[SerializeField]
	private bool _update;

	[SerializeField]
	private Image _rootImageBg;

	[SerializeField]
	private Image _hOverImg;

	[SerializeField]
	private Image _rightFrame;

	[SerializeField]
	private Image _leftFrameTitleLineardodge;

	[SerializeField]
	private Image _rightBg;

	[SerializeField]
	private Image _artwork;

	[SerializeField]
	private TextMeshProUGUI _cardName;

	[SerializeField]
	private TextMeshProUGUI _flavorText;

	[SerializeField]
	private AbnormalityFlavorTextEffect _flavorEffect;

	[SerializeField]
	private AbnormalityFlavorTextEffect _DescEffect;

	[SerializeField]
	private TextMeshProUGUI _abilityDesc;

	[SerializeField]
	private RectTransform _rootRect;

	[SerializeField]
	private RectTransform _rightRect;

	[SerializeField]
	private CanvasGroup _rightCanvasGroup;

	[SerializeField]
	private Image img_LeftTotalFrame;

	[SerializeField]
	private TextMeshProUGUI txt_Level;

	[Header("Pad")]
	public UICustomSelectable selectable;

	private EmotionCardXmlInfo _card;

	private MentalState _state;

	private Vector2 _rootWidth;

	private Vector2 _rightDstPos;

	private float _rightAlpha;

	private bool _bEntered;

	private bool _bDown;

	private bool _bDoneSelect;

	private BattleEffectSound _loopSound;

	private BattleEffectSound _hOverSound;

	private BattleEffectSound _selectSound;

	private Coroutine _cardRotationRoutine;

	private float _elapsedLastHOver;

	[Header("ui type")]
	public bool isNotSelectedCard;

	public bool isInventoryUI;

	private bool _isForceOpen;

	private Vector2 _originRootWidth;

	private Vector2 _originRightDstPos;

	private float _originRightAlpha;

	private float elapsed;

	public EmotionCardXmlInfo Card
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(EmotionCardXmlInfo card, bool forceOpen = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TextMeshProUGUI GetFlavorText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoneSelection()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnExit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSubmit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdEnter(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdExit(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdSubmit(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerDown(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerUp(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RotateRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetLayout()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSprites(MentalState state)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTexts(string cardName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionPassiveCardUI()
	{
		throw null;
	}
}
