using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;

public class RencounterManager : SingletonBehavior<RencounterManager>
{
	[Header("Value Setting")]
	public float coefKnockback;

	[Header("Sound Resource")]
	public AudioClip Draw_AtkAtk;

	public AudioClip Draw_DefDef;

	public AudioClip Dice_Move;

	public AudioClip Dice_Rolled;

	public bool forbidAutoPlay;

	[Header("Phase Delay Setting")]
	[SerializeField]
	private float _tEnableUI;

	[SerializeField]
	private float _tMoveDice;

	[SerializeField]
	private float _tPrintEnemyVanillaDice;

	[SerializeField]
	private float _tPrintEnemyResultDice;

	[SerializeField]
	private float _tWaitLibrarian;

	[SerializeField]
	private float _tPrintLibrarianVanillaDice;

	[SerializeField]
	private float _tPrintLibrarianResultDice;

	[SerializeField]
	private float _tPrintActivatedAbility;

	[SerializeField]
	private float _tChangeMotion;

	[SerializeField]
	private float _tMoveUnits;

	[SerializeField]
	private bool _testNodelay;

	[SerializeField]
	[Range(0f, 1f)]
	private float _afterMovingSmoothTime;

	private float _curMovingSmoothTime;

	[SerializeField]
	private float _delayRatio;

	[SerializeField]
	private float _curDelayRatio;

	[Header("Legacy")]
	[SerializeField]
	private LibrarianPotentialTypo _potentialTypoPrefab;

	private RencounterManager.RencounterState _curRencounterState;

	private bool _isRunning;

	private bool _bPause;

	private BattleUnitView _librarian;

	private BattleUnitView _enemy;

	private BattleUnitView.SkinInfo _originalLibrarianSkin;

	private BattleUnitView.SkinInfo _originalEnemySkin;

	private Queue<BattleCardBehaviourResult> _librarianBehaviourResultQueue;

	private Queue<BattleCardBehaviourResult> _enemyBehaviourResultQueue;

	private List<Queue<BattleCardBehaviourResult>> _otherBehaviourResultQueueList;

	private BattleCardBehaviourResult _currentLibrarianBehaviourResult;

	private BattleCardBehaviourResult _currentEnemyBehaviourResult;

	private List<BattleCardBehaviourResult> _currentOthersBehaviourResultList;

	private Dictionary<RencounterManager.RencounterState, RencounterStateTimer> _stateTimerDic;

	private List<LibrarianPotentialTypo> _createdTypoList;

	private bool _actionAfterBehaviourIsRunning;

	private bool _bMoveSlow;

	private const int _NODELAY_START_COUNT = 2;

	private int _countForNodelay;

	[SerializeField]
	private bool _bNoDelay;

	[SerializeField]
	private bool _autoplay;

	private float _elapsedEndRencounter;

	private float _elapsedStartFocus;

	private bool _bWaitLibrarian;

	[Header("Fields related to MoveRoutine")]
	public bool isPlayPrintDamage;

	public bool isActionPrev;

	public bool isMotionStartPrev;

	public bool isPlayEffectSound;

	private float _elapsedStop;

	private float _elapsedConfrontation;

	private float _elapsedCompetition;

	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool playAuto
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

	public float curMovingSmoothTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public RencounterManager.RencounterState CurRencounterState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNodelay(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartRencounter(BattleUnitView enemy, BattleUnitView librarian)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndRencounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndRencounterForcely()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableUI(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveDice(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckMovingStateBeforeRoll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintEnemyVanillaDice(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintEnemyResultDice(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitLibrarian(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRollDiceInRecounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PotentialEffect(List<string> strList, BattleUnitView view)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintLibrarianVanillaDice(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintLibrarianResultDice(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintActivatedAbility(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveUnits(RencounterStateTimer timer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeTimerDelayByRatio(RencounterStateTimer timer, float delayRatio)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDialogues(List<BattleUnitModel> list, DialogType dlgType, List<BattleUnitModel> targets)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDialogues(BattleUnitView view, DialogType dlgType, List<BattleUnitModel> targets)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangePreMotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintEffect(bool printLibrarian, bool printEnemy, ActionDetail librarianActionDetail, ActionDetail enemyActionDetail, string liCustomRes, string enCustomRes, bool librarianAtkEffectEvent, bool enemyAtkEffectEvent, bool librarianPrintEffectForcely, bool enemyPrintEffectForcely)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintRecovery()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamageWithoutText(BattleUnitView loser)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintSound(BattleUnitView view, BattleCardBehaviourResult selfResult, BattleCardBehaviourResult opponentResult, ActionDetail actionDetail)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMovingStateByActionResult()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BehaviourActionBase CreateBehaviourAction(string s)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HasOriginalBlockMotion(RencounterManager.ActionAfterBehaviour self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetBehaviourAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent, bool isBlocked = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveRoutine(RencounterManager.ActionAfterBehaviour winner, RencounterManager.ActionAfterBehaviour loser)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool StopMoving()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveForward(BattleUnitView self, Vector3 src, Vector3 dst, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveBack(BattleUnitView self, Vector3 src, Vector3 dst, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveToOponnent(BattleUnitView self, BattleUnitView opponent, Vector3 src, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveToOponnent_Near(BattleUnitView self, BattleUnitView opponent, Vector3 src, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveToOponnent_Near2(BattleUnitView self, BattleUnitView opponent, Vector3 src, float speed = 1f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TeleportFront(BattleUnitView self, BattleUnitView opponent, float distance, float dstRotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TeleportBack(BattleUnitView self, BattleUnitView opponent, float distance, float dstRotation)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Knockback(BattleUnitView self, BattleUnitView opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool BlinkBack(BattleUnitView self, Vector3 dst)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Confrontation(BattleUnitView self, BattleUnitView opponent, Vector3 dst, bool clockWise, float speed = 2f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Competition(BattleUnitView self, Vector3 dst)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBehaviourResult()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySound_draw()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlaySound(AudioClip clip)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<RencounterManager.MovingAction> GetMovingAction(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionByWin(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionWinFar(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionWinMelee(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionByDraw(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionDrawFar(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionDrawMelee(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionByLose(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionLoseFar(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> GetMovingActionLoseMelee(RencounterManager.ActionAfterBehaviour self, RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool InMeleeRange(BattleUnitView self, BattleUnitView opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSpecial(BattleUnitView u1, BattleUnitView u2)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Debug_PrintMethodName(int stackFrame = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RencounterManager()
	{
		throw null;
	}

	public struct ActionAfterBehaviour
	{
		public BattleUnitView view;

		public Result result;

		public List<RencounterManager.MovingAction> infoList;

		public DiceBehaviourResultData data;

		public BattleCardBehaviourResult behaviourResultData;

		public bool preventOverlap;

		public RencounterManager.ActionAfterBehaviour.EffectEvent startMoveRoutineEvent;

		public RencounterManager.ActionAfterBehaviour.EffectEvent endMoveRoutineEvent;

		public delegate void EffectEvent();
	}

	public class MovingAction
	{
		public ActionDetail actionDetail;

		public CharMoveState moveState;

		public float knockbackPower;

		public float dstRatio;

		public float dstRotation;

		public float dstDistance;

		public bool updateDirectionAfterAction;

		public float delay;

		public float elapsed;

		public EffectTiming atkEffectTiming;

		public EffectTiming recoverEffectTiming;

		public EffectTiming damagedEffectTiming;

		public float speed;

		public string customEffectRes;

		public bool callAtkEffectEvent;

		public bool printEffectForcely;

		private RencounterManager.MovingAction.MoveCustomEventWithElapsed _moveFunc;

		private List<RencounterManager.MovingAction.CustomAtkEventInfo> _customAtkEventList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MovingAction(ActionDetail actionDetail, CharMoveState moveState, float dstRatio = 1f, bool updateDir = true, float delay = 0.125f, float speed = 1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectTiming(EffectTiming atk, EffectTiming recover, EffectTiming damaged)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveCustom(float deltaTime, float elapsedTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCustomMoving(RencounterManager.MovingAction.MoveCustomEvent m)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCustomMoving(RencounterManager.MovingAction.MoveCustomEventWithElapsed m)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCustomEvent(RencounterManager.MovingAction.CustomEvent e, params object[] p)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvokeCustomEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsExistEffectTiming()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAtkEffectTiming(EffectTiming e)
		{
			throw null;
		}

		public delegate bool MoveCustomEvent(float deltaTime);

		public delegate bool MoveCustomEventWithElapsed(float deltaTime, float elapsedTime);

		public delegate void CustomEvent(params object[] parameters);

		public class CustomAtkEventInfo
		{
			public RencounterManager.MovingAction.CustomEvent customAtkEvent;

			public object[] parameters;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public CustomAtkEventInfo()
			{
				
			}
		}
	}

	public enum RencounterState
	{
		None,
		MoveBeforeStart,
		EnableUI,
		MoveDice,
		PrintEnemyVanillaDice,
		PrintEnemyAbility,
		PrintEnemyResultDice,
		WaitLibrarian,
		PrintLibrarianVanillaDice,
		PrintLibrarianAbility,
		PrintLibrarianResultDice,
		ChangeMotion,
		MoveUnits,
		PrintActivatedAbility
	}
}
