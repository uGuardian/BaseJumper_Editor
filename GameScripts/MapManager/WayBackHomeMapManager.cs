using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WayBackHomeMapManager : CreatureMapManager
{
	private const int _dlgNumPhase1st = 3;

	private const int _dlgNumPhase2nd = 7;

	private const int _dlgNumPhaseSuper = 3;

	private const int _dlgNumPhaseBreak = 5;

	private const float _wayDrawTime = 1f;

	private const int _waybackhomeID = 9070302;

	private const int _waybackhomeID_final = 9070531;

	private bool _break;

	[SerializeField]
	private Transform _wayRoot;

	[SerializeField]
	private SpriteRenderer _filter;

	private WayBackHomeMapManager.WayBackHomeState _state;

	private WayBackHomeMapManager.HomeState _housestate;

	private WayLinePatterRenderer _way1st;

	private WayLinePatterRenderer _way2nd;

	private WayLinePatterRenderer _way3rd;

	public WayBackHomeMapManager.WayBackHomeState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public WayBackHomeMapManager.HomeState HouseState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeStillBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeSetTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomePhase2ndStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeTrySuper()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomePhaseSuperStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeBlockedAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeHitSuper()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeRecoverBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ViewHouse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideHouse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearWays()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear1stWay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear2ndWay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear3rdWay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set1stLine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set2ndLine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set3rdLine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DrawLine(WayLinePatterRenderer renderer, Vector3 _lineStart, Vector3 _lineEnd)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WayBackHomeMapManager()
	{
		throw null;
	}

	public enum WayBackHomeState
	{
		Phase1st,
		Phase2nd_Ready,
		Phase2nd,
		PhaseSuper_Ready,
		PhaseSuper,
		Break,
		Die
	}

	public enum HomeState
	{
		Default,
		Hide
	}
}
