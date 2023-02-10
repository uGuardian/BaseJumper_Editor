using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_704011 : PassiveAbilityBase
{
	private List<PassiveAbility_704021> _pumpkinInfoList;

	private const int _SUMMON_CARD_ID = 970411;

	private const int _OBLIVION_CARD_ID = 970412;

	private const int _STRUGGLE_AREA_CARD_ID = 970415;

	private const int _RAGE_AREA_CARD_ID = 970416;

	private const int _OBLIVION_PATTERN_REPEAT = 2;

	private PassiveAbility_704011.Phase _phase;

	private int _combatElapsedRound;

	private int _oblivionPatternCount;

	private bool _bPlayPattern;

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
	private void SetMapDialogueState(PassiveAbility_704011.Phase p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_704011()
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
