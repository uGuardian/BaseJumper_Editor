using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;
using LOR_DiceSystem;
using LOR_XML;
using UI;
using UnityEngine;
using UnityEngine.Rendering;

public class BattleUnitView : BattleObjectView
{
	public bool _bLockPosY;

	public BattleUnitModel model;

	public Transform camRotationFollower;

	public Transform characterRotationCenter;

	public Transform characterTranslationCenter;

	public BattleUnitInteractor unitInteractor;

	[Header("Sounds Root")]
	public Transform soundRoot;

	[Header("Attack Part")]
	public Transform atkTextRoot;

	public Transform atkEffectRoot;

	public Transform damageTextEffectRoot;

	[Header("Damaged Part")]
	public Color normalDmg;

	public AnimationCurve speedCurve;

	public AnimationCurve rangeCurve;

	public AnimationCurve durationCurve;

	public AnimationCurve angleCurve;

	[SerializeField]
	private Animator damageTextImageAnim;

	[SerializeField]
	private NumbersData nd_damageNumbers;

	[Header("Emotion Level effects")]
	public GameObject curEmotionEffect;

	public Light effectLight;

	public Color positiveLightColor;

	public Color negativeLightColor;

	public GameObject arousalEffect;

	public GameObject collapseEffect;

	[Header("Effect")]
	public CharacterDeadEffect deadEffect;

	public CharacterReturnEffect returnEffect;

	public CharacterAppearEffect appearEffect;

	public CharacterAppearEffect disappearEffect;

	public CharacterEgoEffect egoEffect;

	public CriticalTextsUI criticalUI;

	public List<BloodSpriteEffect> bloodSprites;

	[Header("--------------------Sprite View--------------------")]
	public ActionCharacter actionView;

	public CharacterAppearance charAppearance;

	public SortingGroup charSortingGroup;

	[Header("--------------------Team Color--------------------")]
	public Color enemyColor;

	public Color allyColor;

	[Header("--------------------Upper UI--------------------")]
	public SpeedDiceSetter speedDiceSetterUI;

	public GameObject switchTargetButton;

	public GameObject ControllerGuide;

	public BattleUnitBottomStatUI unitBottomStatUI;

	public BattleUnitCostUI costUI;

	public BattleUnitDiceActionUI diceActionUI;

	public BattleDialogUI dialogUI;

	public AbCardSelector abCardSelector;

	public BattleUnitKeepedDiceUI keepUI;

	public Transform transform_DiceSystem;

	[Header("Pad")]
	public UICustomSelectable_autofind unitSelectable;

	[Header("--------------------LEGACY--------------------")]
	public CompetitionTrail_R moveEffect;

	public GameObject chargeEffect;

	private List<string> _dropBookTexts;

	private bool unStopppable;

	private bool _statNumberEnbled;

	[SerializeField]
	private BattleUnitView.RotationState _rotState;

	private bool _knockDownState;

	private float _damagedElapsed;

	private bool _bFormationReturned;

	private BattleUnitView.SkinInfo _altSkinInfo;

	private BattleUnitView.SkinInfo _skinInfo;

	private bool _skinInit;

	private bool _bRunningDeadEffect;

	private bool _bReadyDeadScene;

	public BattleUnitView.DeadEvent deadEvent;

	private Coroutine _egoEffectCoroutine;

	private float _remainDmgTime;

	private bool _isShakingByDamage;

	public bool FormationReturned
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 WorldPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	public Vector2 UIPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool UnStopppable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool StatNumberEnbled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitView.RotationState rotState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateSkin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeScale(MapSize mapSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitView.SkinInfo GetCurrentSkinInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSkinBySkinInfo(BattleUnitView.SkinInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeEgoSkin(string egoName, bool bookNameChange = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSkin(string charName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCreatureSkin(string creatureName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeHeight(int height)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetSkin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAltSkin(string charName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroySkin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDlg(DialogType dlgType, string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDlg(DialogType dlgType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayDlg(DialogType dlgType, List<BattleUnitModel> targets)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableView(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableStatNumber(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableDiceActionUI(bool b)
	{
		throw null;
	}

	public bool IsRunningDeadEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsReadyDeadScene
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDeadEffect(bool effect = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject GetSpecialDeadEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator WaitDeadEffectRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDeadEffectForcely()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RetreatRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartReturnEffect(Vector3 returnPos, bool ignoreView = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ReturnToFormationEffect(Vector3 srcPos, Vector3 dstPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartEgoSkinChangeEffect(string layer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EgoSkinChangeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HighlightTurn(bool b, Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DamagedWithoutText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Damaged(int dmg, BehaviourDetail detail, int face, BattleUnitModel attacker, AtkResist atkResist = AtkResist.Normal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BreakDamaged(int breakDmg, BehaviourDetail detail, BattleUnitModel attacker, AtkResist atkResist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCriticals(bool breaked, bool maxValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverHp(int recover)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverBp(int recover)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintBloodSprites(int dmg, float curHp)
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
	private IEnumerator ShakeUnitByDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DamagedRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckAtkEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateRotationState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Damage(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Parrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeScale(float timeScale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ResetDamageNumbers(int amount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ActionDetail ConvertDetail(BehaviourDetail bd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KnockDown(bool v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyDropBook(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LockPosY(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowProfile()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowProfile_byPad()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnXEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnYEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitView()
	{
		throw null;
	}

	public class SkinInfo
	{
		public BattleUnitView.SkinState state;

		public string skinName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SkinInfo()
		{
			throw null;
		}
	}

	public enum SkinState
	{
		Default,
		Changed,
		Creature,
		EGO
	}

	public enum RotationState
	{
		Normal,
		Knockback,
		Damaged,
		Dead
	}

	public delegate void DeadEvent(BattleUnitView deadUnitView);
}
