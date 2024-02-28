using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActionManager : SingletonBehavior<ActionManager>
{
	[Header("-------- Reference --------")]
	[SerializeField]
	private DamageText _dmgTextPrefab;

	[SerializeField]
	private Camera _battleCam;

	[SerializeField]
	private Camera _actionCam;

	[SerializeField]
	private Vector3 stdPosA;

	[SerializeField]
	private Vector3 stdPosB;

	[SerializeField]
	private Vector3 stdScaleA;

	[SerializeField]
	private Vector3 stdScaleB;

	[SerializeField]
	private GameObject cloneBackgroundObj;

	[SerializeField]
	private CameraFilterPack_AAA_Blood_Hit bloodFilter;

	[SerializeField]
	private CameraFilterPack_FX_EarthQuake earthquakeFilter;

	[SerializeField]
	private BattleFocusActionUI_Frame frameSc;

	[SerializeField]
	private AnimationCurve _camRotCurve_damaged;

	[SerializeField]
	private AnimationCurve _camRotCurve_waitRolling;

	[SerializeField]
	private ActionTotalDamage _leftTotalDamageObj;

	[SerializeField]
	private ActionTotalDamage _rightTotalDamageObj;

	[SerializeField]
	private Transform characterRoot;

	[Header("-------- Runtime --------")]
	public ActionCharacter unitA;

	public ActionCharacter unitB;

	private bool _bAPosArranged;

	private bool _bInitialized;

	private bool _bActionEnd;

	private bool _bActionEndOnce;

	private BattleResult _leftUnitResult;

	private BattleResult _rightUnitResult;

	private int _leftUnitTotalDamage;

	private int _rightUnitTotalDamage;

	private bool _bWaitPlayerRolling;

	private float _elapsedCamMoving;

	private float _elapsedUnitMoving;

	[SerializeField]
	private BattleUnitBottomUIInBattle leftBottomUI;

	[SerializeField]
	private BattleUnitBottomUIInBattle rightBottonUI;

	public bool IsPosArranged
	{
		get
		{
			return this._bAPosArranged;
		}
	}

	public bool IsActionEnd
	{
		get
		{
			return this._bActionEnd;
		}
	}

	public bool IsReadyAction
	{
		get
		{
			return this.unitA.isReadyAction && this.unitB.isReadyAction;
		}
	}

	public bool IsActionEndOnce
	{
		get
		{
			return this._bActionEndOnce;
		}
	}

	public bool IsInitialized
	{
		get
		{
			return this._bInitialized;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitData(BattleUnitView leftView, BattleUnitView rightView)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBattleResult(ResultData enemyResult, ResultData allyResult)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAction()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WaitRolling(bool b)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamageText(int dmg, ActionCharacter actionView, bool isAdditionalDmg)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnEarthQuakeFilter(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator OnBloodFilter(bool left)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAction()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndActionForcely()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DisplayTotalDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Reset()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ArrangeStartPos(BattleUnitView v1, BattleUnitView v2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DoActions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}
}
