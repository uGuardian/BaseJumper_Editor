using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_205010 : PassiveAbilityBase
{
	private const string _RESPATH_FORSAKEN_MURDERER = "EGO_Murderer";

	private const string _RESPATH_ALLAROUND_HELPER = "EGO_Helper";

	private const string _RESPATH_SINGING_MACHINE = "EGO_SingingMachine";

	private const string _RESPATH_DEAD_BUTTERFLIES = "EGO_Butterfly";

	private const string _RESPATH_FREISCHUTZ = "EGO_Freischutz";

	private const int _EGO_NAME_ID_FORSAKEN_MURDERER = 9020511;

	private const int _EGO_NAME_ID_ALLAROUND_HELPER = 9020521;

	private const int _EGO_NAME_ID_SINGING_MACHINE = 9020531;

	private const int _EGO_NAME_ID_DEAD_BUTTERFLIES = 9020541;

	private const int _EGO_NAME_ID_FREISCHUTZ = 9020551;

	private PassiveAbility_205010.CreaturePhase _currentPhase;

	private List<PassiveAbilityBase> _addedPassiveList;

	public override bool isImmortal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_205010.CreaturePhase currentPhase
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
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PassiveAbility_205010.CreaturePhase CheckNewPhase(PassiveAbility_205010.CreaturePhase currentPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeCurrentPhase(PassiveAbility_205010.CreaturePhase newPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecoverAllStats()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEgoSkin(PassiveAbility_205010.CreaturePhase currentPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPassives(PassiveAbility_205010.CreaturePhase currentPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_205010()
	{
		throw null;
	}

	public enum CreaturePhase
	{
		FORSAKEN_MURDERER,
		ALLAROUND_HELPER,
		SINGING_MACHINE,
		DEAD_BUTTERFLIES,
		FREISCHUTZ
	}
}
