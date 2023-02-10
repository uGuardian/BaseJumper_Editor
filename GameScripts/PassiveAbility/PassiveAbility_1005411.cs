using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_1005411 : PassiveAbilityBase
{
	private const float _loseHpRate = 0.05f;

	private const int _childID = 9100542;

	private const int _maxChild = 4;

	private const int _enrageCondition = 2;

	private const float _healRate = 0.5f;

	private const int _farID1 = 9910401;

	private const int _farID2 = 9910402;

	private const int _nearID = 9910403;

	private const int _bufID = 9910404;

	private const int _strongID = 9910405;

	private const int _superCardID = 9910406;

	private const int _patternCntMaxPhase1 = 3;

	private const int _patternCntMaxPhase2 = 3;

	private int _cardCount;

	private int _patternCount;

	private int _childDead;

	private bool _enraged;

	private bool _phaseFirst;

	private bool _init;

	private SoundEffectPlayer _soundLoop;

	private CameraFilterCustom_Snow _snowFilter;

	public static int FilterLevelDefault;

	public static int FilterLevelEnrage;

	public static int FilterLevelPhaseTwo;

	public static int FilterLevelSuperReady;

	public static int FilterLevelSuper1st;

	public static int FilterLevelSuper2nd;

	public static float[] FilterSpeed;

	public static float[] FilterSize;

	public static float[] FilterIntensity;

	public static float[] FilterFade;

	public static float[] FilterFar;

	public static float[] FilterNear;

	public static float[] FilterDistance;

	public static float[] FilterSpeedX;

	private SnowQueenMapManager_Final _map;

	private SnowQueenMapManager_Final Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isInvincible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUnitCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Enrage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PhaseTwo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroySound()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Super()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFilterLevel(int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattlePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1005411()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PassiveAbility_1005411()
	{
		throw null;
	}
}
