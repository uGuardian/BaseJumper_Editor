using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_903011 : PassiveAbilityBase
{
	private const int _specialID = 990311;

	private const int _deathCntMax = 10;

	private const float _bDmgAllyDied = 0.15f;

	private const float _bDmgEnemyDied = 0.15f;

	private const float _bHealAllyDied = 0.15f;

	private const float _bHealEnemyDied = 0.25f;

	private const int _specialCoolTime = 3;

	private int coolTime;

	private int deathCnt;

	private BlueStarMapManager _map;

	private SoundEffectPlayer _loop;

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

	private int SelfDmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BlueStarMapManager Map
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
	public override void OnEndBattlePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmuneBreakDmg(DamageType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_903011()
	{
		throw null;
	}
}
