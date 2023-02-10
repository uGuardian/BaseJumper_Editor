using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_803011 : PassiveAbilityBase
{
	private const int _specialID = 980311;

	private const int _specialAreaID = 980312;

	private const float _breakRate = 0.2f;

	public const int _specialConditionSinStack = 5;

	public const int _areaConditionSinStack = 3;

	public const int _areaConditionTargetNum = 3;

	private List<BattleUnitModel> targets;

	private LongBirdMapManager _map;

	private LongBirdMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<BattleUnitModel> ChangeSubTargets(BattleDiceCardModel card, BattleUnitModel mainTarget)
	{
		throw null;
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
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetSinFillStackTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckAreaCondition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_803011()
	{
		throw null;
	}
}
