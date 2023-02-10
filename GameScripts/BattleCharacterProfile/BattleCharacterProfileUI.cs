using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattleCharacterProfile
{
	public class BattleCharacterProfileUI : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Transform uiRoot;

		[SerializeField]
		private Image img_bg;

		[SerializeField]
		private BattleUnitProfileInfoUI_EmotionLvTooltip _emotionLvTooltip;

		[Space]
		[Header("Appearance")]
		[SerializeField]
		private RawImage rawImg_portrait;

		[SerializeField]
		private TextMeshProUGUI txt_unitName;

		[Space]
		[Header("HP")]
		[SerializeField]
		private GameObject go_hpValueLayout;

		[SerializeField]
		private GameObject go_emotionLVPivot;

		[SerializeField]
		private BattleCharacterProfileUI.HpBar hpBar;

		[SerializeField]
		private BattleCharacterProfileUI.HpBar img_damagedHp;

		[SerializeField]
		private BattleCharacterProfileUI.HpBar img_healedHp;

		[SerializeField]
		private NumbersData nd_hpNumbers;

		[SerializeField]
		private Text txt_hp;

		[Space]
		[Header("Emotion")]
		[SerializeField]
		private List<Image> img_emotionCoinList;

		[SerializeField]
		private BattleCharacterProfileUI_CoinManager coinUI;

		[SerializeField]
		private BattleCharacterProfileEmotionUI emotionUI;

		[Space]
		[SerializeField]
		private Color _colorDialogBG_New;

		[SerializeField]
		private CanvasGroup _battleDialogCanvasGroup;

		[SerializeField]
		private TextMeshProUGUI _battleDialog;

		[SerializeField]
		private Image _battleDialogBG;

		[SerializeField]
		private Image _battleDialogNewBG;

		[SerializeField]
		private Image _battleDialogChildImg;

		[SerializeField]
		private Image _battleDialogLinearDodge;

		private bool isExited;

		public bool isLeft;

		private int emotionLV_Prev;

		private BattleUnitInformationUI playerinfo;

		private BattleUnitInformationUI enemyinfo;

		private BattleUnitModel _unitModel;

		private bool _grayScaled;

		private float _curHp;

		private Coroutine displayDlgRoutine;

		private Coroutine hideDlgWithDelayRoutine;

		private bool _bDlgIsAbnormality;

		private MentalState _bAbnormalityState;

		private Coroutine clickableRoutine;

		private float _emotion_elap;

		private float _emotion_duration;

		private bool _isAcquireProcess;

		private BattleCharacterProfileUI.OnAcquireEnd _onAcquireEnd;

		private int _negativeIndex;

		private int _positiveIndex;

		public BattleUnitModel UnitModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float CurHp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClick(bool byPad)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitModel(BattleUnitModel unitModel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayDlg(string str, bool isAbnormality, MentalState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDlgArea()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseDlgWithDelay()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator HideRoutineWithDelay(int delay = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator DisplayRoutine(bool show, bool isAbnormality, MentalState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterDlgArea()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator EnterRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitDlgArea()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ClickableEffectRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStatNumberEnable(bool enable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHpUI(float newHp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator UpdateHpBar(BattleCharacterProfileUI.HpBar src, BattleCharacterProfileUI.HpBar dst, float curHp, float newHp, BattleCharacterProfileUI.HpBar bar)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator UpdateHpNum(float curHP, float newHP)
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
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAcquireProcess(bool state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator AcquireCoroutine(Image targetImage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitEmotionCoin()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAcquireCoin(bool isPositive, int emotionLevel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEmotionCoinList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGrayscale(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Image> GetChildRecursiveList(Transform t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultCoinImgScale()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCharacterProfileUI()
		{
			throw null;
		}

		[Serializable]
		public class HpBar
		{
			public Image img;

			public _2dxFX_HSV hsv;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HpBar()
			{
				throw null;
			}
		}

		public delegate void OnAcquireEnd();
	}
}
