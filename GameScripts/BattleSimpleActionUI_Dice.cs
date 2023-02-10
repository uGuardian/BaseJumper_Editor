using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleSimpleActionUI_Dice : MonoBehaviour
{
	[Header("Resource")]
	[SerializeField]
	private List<Sprite> refSprites_number;

	[SerializeField]
	private List<BattleFocusActionUI_Dice.DiceSprite> refSprites_dice;

	[SerializeField]
	private List<Sprite> refSprites_typeIcon;

	[SerializeField]
	private Sprite iconSlash;

	[SerializeField]
	private Sprite iconPenetrate;

	[SerializeField]
	private Sprite iconHit;

	[SerializeField]
	private Sprite iconGuard;

	[SerializeField]
	private Sprite iconEvade;

	[SerializeField]
	private List<BattleSimpleActionUI_Dice.DiceEffect> diceEffects;

	[Header("Runtime")]
	public CanvasGroup canvasGroup;

	public Animator animator;

	public Image img_diceFaceClone;

	public Image img_diceFaceLinearDodgeClone;

	public Image img_diceFace;

	public Image img_diceFaceLinearDodge;

	public Image imgIcon;

	public Image imgDetailIcon_Center;

	public Image img_diceDestroyed;

	public Image img_diceDestoryedLinearDodge;

	[Header("Numbers")]
	public HorizontalLayoutGroup numberlayout;

	public Image img_hundredsPlace;

	public Image img_tensPlace;

	public Image img_unitsPlace;

	public Image img_hundredsPlaceBg;

	public Image img_tensPlaceBg;

	public Image img_unitsPlaceBg;

	public RefineHsv hsv_HundredsPlace;

	public RefineHsv hsv_TensPlace;

	public RefineHsv hsv_unitsPlace;

	public Image img_diceEffect;

	public Transform layout_numbers;

	public Transform layout_numberbgs;

	public TextMeshProUGUI txt_diceRange;

	private BattleDiceCardModel _cardOfBehaviour;

	private List<BattleCardBehaviourResult> _battleBehaviourList;

	private bool _bSkipEnd;

	private bool _bdestroyedEnd;

	private DiceEffectType _currentEffectType;

	[Header("img_ActionDefeatDestoryedLinear")]
	[SerializeField]
	private Image img_ActionDefeatDestoryed;

	[SerializeField]
	private Image img_ActionDefeatDestoryedLinear;

	public bool isRunningDestroyAnim;

	public bool isRunningDesbyCardAnim;

	public bool isStartBeforeAnim;

	public bool isAleadySetAnimTrigger;

	public BattleDiceBehaviourUI diceBeUI;

	public BehaviourType behaviourType;

	private Color originColor;

	public BattleDiceCardModel cardOfBehaviour
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isBreaked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsSkipEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsDestroyedEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public DiceEffectType CurrentEffectType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionDestroyedAnimByCardAbility()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionDefeatDestroyAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActionDefeatDestoryAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartVibeDiceInAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopVibeDiceInAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeProcess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSkipAnimStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSkipAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyedAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSkip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isSkipTest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveResult()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceValue(bool enable, int diceValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator nextFrameBgPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceFace(int diceFace)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDice(BattleDiceBehavior diceBehaviour, bool numberOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCenterIcon(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCenterIconSprite(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PrepareDice(List<BattleCardBehaviourResult> battleDiceBehaviorResults)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRangeText(DiceBehaviour behaviour, int min, int max)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRangeText(DiceBehaviour behaviour)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareDice(BattleDiceBehavior b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareDice(BattleDiceBehaviourUI b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OffDiceValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValueColor(BattleDiceValueColor colorstate)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColors(BehaviourType type, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFaceSprite(BattleFocusActionUI_Dice.DiceSprite sprInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetIndex(int face)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleFocusActionUI_Dice.DiceSprite GetFaceSprite(int face)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleSimpleActionUI_Dice.DiceEffect GetDiceEffectData(DiceEffectType effectType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceEffect(DiceEffectType effectType = DiceEffectType.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceEffect(int face = -1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleSimpleActionUI_Dice()
	{
		throw null;
	}

	[Serializable]
	public class DiceEffect
	{
		public Sprite[] sprites;

		public DiceEffectType type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetSprite(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceEffect()
		{
			throw null;
		}
	}
}
