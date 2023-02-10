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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBreakFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeStillBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeSetTarget()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomePhase2ndStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeTrySuper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomePhaseSuperStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeBlockedAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeHitSuper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WayBackHomeRecoverBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ViewHouse()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideHouse()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearWays()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear1stWay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear2ndWay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear3rdWay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set1stLine()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set2ndLine()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set3rdLine()
	{
		
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
