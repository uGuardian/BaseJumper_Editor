using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_805221 : PassiveAbilityBase
{
	private const int _defenseID = 9908225;

	private const int _powBySpeed = 2;

	private const int _rebirthCoolTime = 3;

	private int _speed;

	private int _rebirthTurn;

	private SmallBirdFinalMapManager _map;

	private bool _isActivated;

	private PassiveAbility_805221.BirdState _state;

	private SmallBirdFinalMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isImmortal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isTargetable
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
	public void OnRoundStart_Attack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_Defense()
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
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_805221()
	{
		throw null;
	}

	private enum BirdState
	{
		ATTACK,
		DEFENSE
	}
}
