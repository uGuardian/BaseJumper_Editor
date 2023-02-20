using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_105010 : PassiveAbilityBase
{
	public const string _RESPATH_SCORCHED_GIRL = "EGO_ScorchedGirl";

	public const string _RESPATH_TEDDY = "EGO_Teddy";

	public const string _RESPATH_FAIRY = "EGO_Fairy";

	public const string _RESPATH_QUEEN_BEE = "EGO_QueenBee";

	public const string _RESPATH_WHITE_SNOW = "EGO_SnowWhite";

	private PassiveAbility_105010.CreaturePhase _currentPhase;

	private PassiveAbility_105010.CreaturePhase _newPhase;

	private List<PassiveAbilityBase> _addedPassives;

	public override bool isImmortal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_105010.CreaturePhase currentPhase
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
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PassiveAbility_105010.CreaturePhase SetNextPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeAbility()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_105010()
	{
		throw null;
	}

	public enum CreaturePhase
	{
		SCHORCHED_GIRL,
		TEDDY,
		FAIRY,
		QUEEN_BEE,
		WHITE_SNOW
	}
}
