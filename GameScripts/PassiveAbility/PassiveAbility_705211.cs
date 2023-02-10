using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_705211 : PassiveAbilityBase
{
	private const int _treeID = 9070522;

	private const int _specialID = 9907215;

	private const int _counterID = 9907216;

	private const float _healPerKillRate = 0.2f;

	private const int _stackPerKill = 3;

	private const int _heartlessTurnMax = 3;

	private const string _breakSkin = "EGO_Lumberjack_Break";

	private const string _defaultSkin = "EGO_Lumberjack";

	private int heartlessTurn;

	private BattleUnitModel _target;

	private PassiveAbility_705211.LumberjackState _state;

	private SoundEffectPlayer _heartSound;

	private BattleUnitBuf_Lumberjack_WarmHeart_Final _heart;

	private BattleUnitBuf_Lumberjack_Mind_Fragment _fragment;

	private LumberjackMapManager map;

	private BattleUnitBuf_Lumberjack_WarmHeart_Final Heart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BattleUnitBuf_Lumberjack_Mind_Fragment Fragment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private LumberjackMapManager Map
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
	public override bool TeamKill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_1st()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_2nd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_Heartless()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRoundStart_Break()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BreakDown()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecoverBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetWeakestTree()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillTree()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnKill(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Effect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HeartSoundOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopHeartSound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_705211()
	{
		throw null;
	}

	private enum LumberjackState
	{
		PHASE_1ST,
		PHASE_2ND,
		HEARTLESS,
		BREAK
	}
}
