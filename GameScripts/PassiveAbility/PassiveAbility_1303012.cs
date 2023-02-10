using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_1303012 : PassiveAbilityBase
{
	private const int _weakGuardID = 703311;

	private const int _strongGuardID = 703312;

	private const int _stunID = 703313;

	private const int _seasoningID = 703314;

	private const int _cut1ID = 703315;

	private const int _cut2ID = 703316;

	private const int _tasteID = 703317;

	private const int _trampleID = 703318;

	private const int _catchID = 703319;

	private const int _mealID = 703310;

	private const int _meatID = 1303021;

	private const int _patternCntMax = 5;

	private const int _resistanceStackStart = 10;

	private const int _resistanceStack = 10;

	private const float _hpRate_phase = 0.4f;

	private const float _hpRate_nodmg = 0.3f;

	private int _cardCount;

	private int _patternCount;

	private BattleUnitModel _meat;

	private bool _transformed;

	private int _dmgReduction;

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
	public override void OnLoseHp(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetDamageReductionAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_phase1()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetAddedDiceCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1303012()
	{
		throw null;
	}
}
