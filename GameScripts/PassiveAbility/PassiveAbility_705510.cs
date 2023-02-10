using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_705510 : PassiveAbilityBase
{
	private bool _bInvincibleHp;

	private bool _bInvincibleBp;

	private PassiveAbility_705510.Phase _phase;

	private int _elapsedLumberjackPhase;

	private int _cooldownHomePhaseAreaAtk;

	private const int _NONE_PHASE_AREA_ATK_1_CARD_ID = 9907515;

	private const int _NONE_PHASE_AREA_ATK_2_CARD_ID = 9907516;

	private const int _NONE_PHASE_AREA_ATK_3_CARD_ID = 9907517;

	private bool _bPolymorphed;

	private const string _POLYMORPH_EFFECT_PATH = "Battle/DiceAttackEffects/New/FX/Mon/Wizard/FX_Mon_Wizard_Trans";

	public override bool isInvincibleHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isInvincibleBp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isActionable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_705510.Phase phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Polymorph()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(PassiveAbility_705510.Phase nextPhase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitLumberJackPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitScareCrowPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitLionPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitWaybackHomePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitRagePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_705510()
	{
		throw null;
	}

	public enum Phase
	{
		None,
		Lumberjack,
		Scarecrow,
		Lion,
		WaybackHome,
		Rage
	}
}
