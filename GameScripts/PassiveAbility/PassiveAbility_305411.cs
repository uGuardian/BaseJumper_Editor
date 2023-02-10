using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_305411 : PassiveAbilityBase
{
	private const int _draw = 6;

	private const int _recoverPP = 3;

	private const int _maxHp = 300;

	private const int _maxBp = 100;

	private const int _speedDiceNum = 3;

	private const int _speedDiceMin = 2;

	private const int _speedDiceMax = 6;

	private const int _startPP = 3;

	private const int _maxPP = 3;

	private const int _defRedRate = 4;

	private const int _atk1ID = 9903411;

	private const int _atk2ID = 9903415;

	private const int _spID = 9903414;

	private const int _heartID = 9903451;

	private const int _heartID_Ranged = 9903452;

	private const int _pinkID = 9030542;

	private const int _friendID = 9030543;

	private const int _spTurn = 3;

	private List<BattleUnitModel> _childList;

	private bool _recoverBreakOnRoundStart;

	private int spTurn;

	private int turn;

	private int pinkDiedThisTurn;

	private int killedPinkThisTurn;

	private int friendDied;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroyed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpec()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
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
	private bool OnlySurvive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetHeartCount(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeFriend(int cnt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakePink()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int CheckLibrarianHeart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_305411()
	{
		throw null;
	}
}
