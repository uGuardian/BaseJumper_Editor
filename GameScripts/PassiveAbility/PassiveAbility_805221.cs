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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_Attack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_Defense()
	{
		
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
