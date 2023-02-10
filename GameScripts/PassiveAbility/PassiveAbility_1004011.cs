using System;
using System.Runtime.CompilerServices;
using Sound;

public class PassiveAbility_1004011 : PassiveAbilityBase
{
	private const float _loseHpRate = 0.05f;

	private const int _speedDiceNum = 2;

	private const int _childID = 9100402;

	private const int _maxChild = 3;

	private const int _enrageCondition = 2;

	private const float _healRate = 0.5f;

	private const int _addedCardID1 = 902903;

	private const int _addedCardID2 = 902904;

	private const int _addedCardID3 = 902905;

	private const int _addedCard1Num = 3;

	private const int _addedCard2Num = 2;

	private const int _addedCard3Num = 2;

	private const int _superCardID = 902906;

	private const int _coolTime = 3;

	private int _childDead;

	private int _turn;

	private bool _enraged;

	private bool _phaseFirst;

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

	private SnowQueenMapManager _map;

	private SnowQueenMapManager Map
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
	public PassiveAbility_1004011()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PassiveAbility_1004011()
	{
		throw null;
	}
}
