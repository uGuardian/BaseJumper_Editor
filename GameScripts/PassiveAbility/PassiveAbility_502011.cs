using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_502011 : PassiveAbilityBase
{
	private PassiveAbility_502011.Phase _currentPhase;

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

	public PassiveAbility_502011.Phase CurrentPhase
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StuckSword()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BlessToSword(int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBlessFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFatalFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableStuckSwordFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGroggyFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDeadEvent(BattleUnitView ownerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_502011()
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
