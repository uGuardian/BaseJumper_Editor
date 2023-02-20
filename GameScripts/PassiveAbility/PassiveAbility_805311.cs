using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_805311 : PassiveAbilityBase
{
	private const int _specialID = 9908311;

	private const int _specialAreaID = 9908312;

	private const int _defenseID = 9908316;

	private const float _breakRate = 0.25f;

	private const int _rolandStartSin = 10;

	private const int _specialTargetNumMax = 3;

	public const int _specialConditionSinStack = 5;

	public const int _areaConditionSinStack = 3;

	public const int _areaConditionTargetNum = 3;

	private List<BattleUnitModel> targets;

	private List<BattleUnitModel> normalTargets;

	private LongBirdMapManager _map;

	private bool _normalTurn;

	private LongBirdMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<BattleUnitModel> ChangeSubTargets(BattleDiceCardModel card, BattleUnitModel mainTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetNormalTargets()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetSinFillStackTargets()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckAreaCondition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_805311()
	{
		throw null;
	}
}
