using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace LOR_BattleUnit_UI
{
	public class SpeedDiceUI : MonoBehaviour
	{
		[Header("Sprite Reference")]
		[SerializeField]
		private SpeedDiceUI.SpriteReference Refs;

		[Header("Reference")]
		[SerializeField]
		private BattleUnitView _view;

		public UICustomSelectable selectable;

		public UICustomSelectableSpeedDice diceSelectable;

		[Header("NormalDice References")]
		[SerializeField]
		private GameObject _normalDiceRoot;

		[SerializeField]
		private Image img_normalFrame;

		[SerializeField]
		private Image img_lightFrame;

		[SerializeField]
		private Animator anim_lightFrame;

		[SerializeField]
		private Image img_tensNum;

		[SerializeField]
		private Image img_unitsNum;

		[Space(5f)]
		[SerializeField]
		private Image _rouletteMaskImg;

		[SerializeField]
		private RawImage _rouletteImg;

		[SerializeField]
		private Text _txtSpeedRange;

		[SerializeField]
		private TextMeshProUGUI _txtSpeedMax;

		[Header("BreakDice References")]
		[SerializeField]
		private GameObject _breakDiceRoot;

		[SerializeField]
		private Image img_breakedFrame;

		[SerializeField]
		private Image img_breakedLinearDodge;

		[Header("LockDice References")]
		[SerializeField]
		private GameObject _lockDiceRoot;

		[SerializeField]
		private Image img_lockedFrame;

		[SerializeField]
		private Image img_lockedIcon;

		[Header("BlockDice References")]
		[SerializeField]
		private GameObject _blockDiceRoot;

		[SerializeField]
		private Animator anim_BlockSelectDice;

		[Header("Highlight References")]
		[SerializeField]
		private Image img_highlightFrame;

		[SerializeField]
		private Animator anim_highlightFrame;

		public RectTransform rect;

		private SpeedDiceSetter _parentSetterUI;

		private int _speedDiceIndex;

		private int _speedDiceValue;

		private BattleUnitInformationUI playerinfo;

		private BattleUnitInformationUI enemyinfo;

		private Vector2 _rouletteVibeOffset;

		private float _rouletteImgSpeed;

		public SpeedDiceUI.OnSelectTutorial selectFuncForTutorial;

		private bool isLightOn;

		private bool isHighlighted;

		private bool isClicked;

		private bool _bBreakedDice;

		private RectTransform _normalDiceRootRect;

		private bool _bRolledSpeedDice;

		private bool showProfilePlayerByPad;

		private int switchableIdx;

		private List<SpeedDiceUI> switchableTargets;

		public BattleUnitView view
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int OrderOfDice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public BattlePlayingCardDataInUnitModel CardInDice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int index, int diceMin, int diceFace, Faction faction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSprite(int face, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightOn(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlight(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightClicked()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetClickedState(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnableSwitchTargetObject(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BreakDice(bool breaked, bool locked = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckBlockDice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlockDice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlockDice(bool active, bool forcely = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimBlockDice(bool selected)
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
		private IEnumerator RouletteDisableRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateControllerGuide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPdCancel(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPdButtonX(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPdButtonY(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EmptySpeedDiceSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveToUnitInformationByPad()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnClickSpeedDice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectCard()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDicePreview()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideDicePreview(bool forceHide = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearTargetArrows()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ShowSwitchableTarget(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSwitchTarget(bool isController)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeedDiceUI()
		{
			throw null;
		}

		[Serializable]
		private struct SpriteReference
		{
			public List<Sprite> ref_numbers;

			public Sprite ref_normalFrame_ally;

			public Sprite ref_lightFrame_ally;

			public Sprite ref_linearDodgeFrame_ally;

			public Sprite ref_normalFrame_enemy;

			public Sprite ref_lightFrame_enemy;

			public Sprite ref_linearDodgeFrame_enemy;

			[Space(5f)]
			public Color color_allyDice;

			public Color color_allyDiceLine;

			public Material mat_allyDiceLineGlow;

			public Color color_enemyDice;

			public Color color_enemyDiceLine;
		}

		[HideInInspector]
		public delegate void OnSelectTutorial();
	}
}
