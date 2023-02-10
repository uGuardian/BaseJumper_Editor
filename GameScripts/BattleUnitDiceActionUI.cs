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
		throw null;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFirstDiceNew()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceAnimation(CompareBehaviourUIType type, DiceUITiming timing)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDice(int diceFace, int diceValue, bool isResultDice, BattleDiceValueColor colorstate = BattleDiceValueColor.Normal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceNew(int diceFace, int diceValue, bool isResultDice, BattleDiceValueColor colorstate = BattleDiceValueColor.Normal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionResultDestroyedDice()
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveCardDuringRoulette(Queue<BattleEmotionCardModel> q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateEmotionCards(Queue<BattleEmotionCardModel> q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRoulette()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableTypoCanvas(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTypo(List<string> strList, ActionTextMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTypo(List<EffectTypoData> datas)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideOffPrevTypo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ActionTextRoutine(List<string> strList, ActionTextMode mode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDicesNew()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitAdditionalBehaviour()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetFirstDicePosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitWithoutLog(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitDicesWithoutLog(List<BattleDiceBehavior> behaviourList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFirstDiceWithoutLog(BattleDiceBehavior behaviour)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllDice(List<BattleDiceBehavior> behaviourList, bool onlyFirst)
	{
		throw null;
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
