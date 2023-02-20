using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitDiceActionUI : MonoBehaviour
{
	[Header("Resources")]
	[SerializeField]
	private ActionText _actionTextPrefab;

	[SerializeField]
	private GameObject _actionTextBgEffectPrefab;

	[SerializeField]
	private Color enemyFrameColor;

	[SerializeField]
	private Color enemyTextColor;

	[SerializeField]
	private Color enemyLineardodgeColor;

	[SerializeField]
	private Color librarianFrameColor;

	[SerializeField]
	private Color librarianTextColor;

	[SerializeField]
	private Color librarianLineardodgeColor;

	[Header("------------ References ------------")]
	public TextMeshProUGUI txt_range;

	[SerializeField]
	private List<BattleUnitDiceActionUI.DiceTransformStd> _transformStdList;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Image _frame;

	[SerializeField]
	private Image _frame2;

	[SerializeField]
	private Image _frame3;

	[SerializeField]
	private Image _lineardodge;

	[SerializeField]
	private Image img_artwork_BG;

	[SerializeField]
	private Image img_artwork;

	[SerializeField]
	private BattleUnitView _unitView;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private List<BattleSimpleActionUI_Dice> _remainDiceList;

	[SerializeField]
	private List<BattleSimpleActionUI_Dice> _remainDiceAnimSlotList;

	[SerializeField]
	private TextMeshProUGUI _cardName;

	[SerializeField]
	private TextMeshProUGUI _criticalValue;

	[SerializeField]
	private GameObject _criticalRootObj;

	[SerializeField]
	private GameObject _rouletteObj;

	[SerializeField]
	private RawImage _rouletteImage;

	[SerializeField]
	private Transform _objectRoot;

	private Vector3 _objectRootOriginPos;

	private int _firstDiceIdx;

	private List<BattleEmotionCardModel> _abPassiveList;

	[Header("Typo")]
	[SerializeField]
	private BattleActionTypoUI actionTypo;

	private bool _bInitAnimEnd;

	private List<BattleCardBehaviourResult> currentResult;

	public int behaviourResultidx;

	public BattleSimpleActionUI_Dice currentDice;

	private bool _bRunningResultDiceEffect;

	private Coroutine moveCardRoutine;

	public float moveCardSpeed;

	private List<BattleCardBehaviourResult> behaviourResults;

	private Queue<List<BattleCardBehaviourResult>> qq;

	private List<List<BattleCardBehaviourResult>> resultorder;

	private bool isSetFirstDice;

	public Direction UnitDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Canvas rootCanvas
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Transform ObjectRoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitModel target = null)
	{
		
	}

	public bool IsInitAnimEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnInitAnimEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFirstDiceNew()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceAnimation(CompareBehaviourUIType type, DiceUITiming timing)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDice(int diceFace, int diceValue, bool isResultDice, BattleDiceValueColor colorstate = BattleDiceValueColor.Normal)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceNew(int diceFace, int diceValue, bool isResultDice, BattleDiceValueColor colorstate = BattleDiceValueColor.Normal)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionResultDestroyedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ResultDiceEffect(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollRoulette(Queue<BattleEmotionCardModel> q)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveCardDuringRoulette(Queue<BattleEmotionCardModel> q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateEmotionCards(Queue<BattleEmotionCardModel> q)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRoulette()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableTypoCanvas(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTypo(List<string> strList, ActionTextMode mode)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTypo(List<EffectTypoData> datas)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideOffPrevTypo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ActionTextRoutine(List<string> strList, ActionTextMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAction()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDicesNew()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitAdditionalBehaviour()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetFirstDicePosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitWithoutLog(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitDicesWithoutLog(List<BattleDiceBehavior> behaviourList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFirstDiceWithoutLog(BattleDiceBehavior behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllDice(List<BattleDiceBehavior> behaviourList, bool onlyFirst)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitDiceActionUI()
	{
		throw null;
	}

	[Serializable]
	private class DiceTransformStd
	{
		public Vector3 localPos;

		public Vector3 localScale;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceTransformStd()
		{
			throw null;
		}
	}
}
