using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleFocusActionUI_Info : MonoBehaviour
{
	[Header("Reference")]
	public Image[] img_frames;

	public Transform diceListRoot;

	public List<BattleFocusActionUI_Dice> diceList;

	public BattleFocusActionUI_Dice curDice;

	public Image rollingImage;

	public TextMeshProUGUI txt_curDiceAbility;

	public BattleDiceCardUI cardUI;

	public RectTransform passiveLowerFrame;

	public Vector3 passiveStartPos;

	public float abilitySpacingValue;

	[SerializeField]
	private List<BattleFocusActionUI_Info.PassiveUI> ui_passiveList;

	public Animator animator;

	[Header("Runtime")]
	public bool initialized;

	public bool IsActionEnd;

	public bool IsVibeEnd;

	private int curDiceIdx;

	private int _curPassiveTextIdx;

	private BattlePlayingCardDataInUnitModel _playingCard;

	private Vector3 defaultPos_diceListRoot;

	private List<Vector3> defaultPos_dices;

	private Vector3 defaultScale_curDice;

	private Vector3 defaultPos_curDice;

	private float _animSpeed;

	private float _destroyAnimRemainingTime;

	private bool _ready;

	public bool IsDestroyActionEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableCurDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetUI()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattlePlayingCardDataInUnitModel playingCard, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceState(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFailDice(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAppearAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMainSlotAnimationBeforeResult()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMainDiceSlotAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartVibeAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndVibeAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndRollingDiceAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndVanillaActionAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DuringActionAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActionAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPreRollData(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetResultData(BattlePlayingCardDataInUnitModel playingCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeActionDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ArrangeUpperDices()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetFrameImg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleFocusActionUI_Info()
	{
		throw null;
	}

	[Serializable]
	private class PassiveUI
	{
		public Image img;

		public TextMeshProUGUI txt;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Enable(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveUI()
		{
			throw null;
		}
	}
}
