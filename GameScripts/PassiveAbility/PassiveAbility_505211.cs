﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_505211 : PassiveAbilityBase
{
	private PassiveAbility_505211.Phase _currentPhase;

	private int _currentRound;

	private List<BattleUnitModel> _swords;

	private BattleUnitModel _blessedSword;

	private bool _bGroggy;

	private int _fatalRoundCount;

	private int _stuckSwordCount;

	public override bool isActionable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isTargetable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_505211.Phase CurrentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int StuckSword()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BlessToSword(int stack)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBlessFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFatalFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableStuckSwordFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGroggyFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDeadEvent(BattleUnitView ownerView)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_505211()
	{
		throw null;
	}

	public enum Phase
	{
		Normal,
		Blessing,
		Fatal,
		Groggy,
		AfterFatal
	}
}
