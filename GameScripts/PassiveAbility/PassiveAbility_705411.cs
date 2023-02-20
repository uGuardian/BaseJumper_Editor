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
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
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
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSuccessFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayOblivionPattern()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayCombatPattern()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayStrugglePattern()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayRagePattern()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreatePumpkins()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AwakenPumpkins(bool wakeUp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapDialogueState(PassiveAbility_705411.Phase p)
	{
		
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
