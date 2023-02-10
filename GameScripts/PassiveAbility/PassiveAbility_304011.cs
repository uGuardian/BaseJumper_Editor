using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_304011 : PassiveAbilityBase
{
	private const int _diceNum = 2;

	private const int _defRedRate = 4;

	private const int _atkID = 902411;

	private const int _atkSPID = 902414;

	private const int _heartID = 902451;

	private const int _heartID_Ranged = 902452;

	private const int _pinkID = 9030402;

	private const int _friendID = 9030403;

	private int turn;

	private int pinkDiedThisTurn;

	private int killedPinkThisTurn;

	private int friendDied;

	private bool friendMade;

	private bool super;

	private List<BattleUnitModel> _friendList;

	private LatitiaMapManager map;

	private LatitiaMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
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
	private int CheckLibrarianHeart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDlgPhase(LatitiaMapManager.DlgPhase phase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_304011()
	{
		throw null;
	}
}
