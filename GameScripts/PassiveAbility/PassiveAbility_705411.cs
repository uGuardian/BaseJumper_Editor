using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_705411 : PassiveAbilityBase
{
	private List<PassiveAbility_705421> _pumpkinInfoList;

	private const int _SUMMON_CARD_ID = 9907411;

	private const int _OBLIVION_CARD_ID = 9907412;

	private const int _STRUGGLE_AREA_CARD_ID = 9907415;

	private const int _RAGE_AREA_CARD_ID = 9907416;

	private PassiveAbility_705411.Phase _phase;

	private int _combatElapsedRound;

	private int _oblivionPatternCount;

	private bool _bPlayPattern;

	private const int _OBLIVION_PATTERN_REPEAT = 2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
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
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSuccessFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayOblivionPattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayCombatPattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayStrugglePattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayRagePattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreatePumpkins()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AwakenPumpkins(bool wakeUp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapDialogueState(PassiveAbility_705411.Phase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_705411()
	{
		throw null;
	}

	public enum Phase
	{
		Oblivion,
		Combat,
		Struggle,
		Rage
	}
}
