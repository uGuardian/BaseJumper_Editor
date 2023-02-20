using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_702011 : PassiveAbilityBase
{
	private const int _stack = 2;

	private const int _speedDiceNum = 3;

	private const string _defenseSkin = "Lumberjack_Def";

	private const string _attackSkin = "Lumberjack_Atk";

	private const int _treeID = 9070202;

	private const int _defCardID = 902101;

	private const int _spCardID = 902106;

	private bool stageStart;

	private bool breaked;

	private int turn;

	private SoundEffectPlayer _heartSound;

	private LumberjackMapManager map;

	private bool trigger;

	private LumberjackMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnMakeBreakState(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_Phase_1()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_Phase_2()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetTree()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Transform()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopHeartSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroyed()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_702011()
	{
		throw null;
	}
}
