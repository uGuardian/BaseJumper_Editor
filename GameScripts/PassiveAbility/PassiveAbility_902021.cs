using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_902021 : PassiveAbilityBase
{
	private const int _DEFAULT_CARD_1_ID = 990202;

	private const int _DEFAULT_CARD_2_ID = 990203;

	private BattleUnitModel _librarian;

	private List<LorId> _copiedCardIdList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

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
	public override void OnRoundStartAfter()
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
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetCorrespondingLibrarian()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCorrespondingLibrarian()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyCardUsedInThisRound(BattleUnitModel u)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyStats(BattleUnitModel u)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCardFromCopies(List<LorId> copiedCards)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveBuf()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_902021()
	{
		throw null;
	}
}
