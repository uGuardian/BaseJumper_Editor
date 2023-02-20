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
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(PassiveAbility_705510.Phase nextPhase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitLumberJackPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitScareCrowPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitLionPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitWaybackHomePhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitRagePhase()
	{
		
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
