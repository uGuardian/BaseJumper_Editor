using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_240008 : PassiveAbilityBase
{
	private BattleUnitModel _noahUnit;

	private bool _readyGetOff;

	private int _noahMaxHp;

	private int _noahHp;

	private int _patternCount;

	private PassiveAbility_240008.BossState _state;

	public override string debugDesc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private bool HasNoah
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_240008.BossState State
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
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapFilter(bool union)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapBrightness(bool toBright)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetOffNoah()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_240008()
	{
		throw null;
	}

	public enum BossState
	{
		EmaNoah,
		NoahDead,
		EmaOnly
	}
}
