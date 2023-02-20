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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattlePlayingCardDataInUnitModel playingCard, float speed = 1f)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceState(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFailDice(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAppearAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartActionAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMainSlotAnimationBeforeResult()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMainDiceSlotAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartVibeAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndVibeAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndRollingDiceAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndVanillaActionAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DuringActionAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActionAnimation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPreRollData(BattlePlayingCardDataInUnitModel playingCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetResultData(BattlePlayingCardDataInUnitModel playingCard)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetText()
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
	private void LateUpdate()
	{
		
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveUI()
		{
			throw null;
		}
	}
}
