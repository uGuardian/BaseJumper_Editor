using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_404011 : PassiveAbilityBase
{
	private const int _diceNum = 2;

	private const int _drawNum = 2;

	private const int _bufID = 902604;

	private const int _superID = 902605;

	private const int _childID = 9040402;

	private const int _childID2 = 9040403;

	private const int _maxPetal = 3;

	private const float _bRecoverRate = 0.5f;

	private const int _loseHpMin = 40;

	private const int _loseHpMax = 40;

	private PassiveAbility_404011.AlriunePhase _phase;

	private CreatureEffect_Alriune_Petal _effect;

	private BattleUnitBuf_Alriune_Petal _buf;

	private AlriuneMapManager _map;

	private CreatureEffect_Alriune_Curtain _curtain;

	private int _deadCnt;

	private int _petalCnt;

	private bool speedDown;

	private static int LoseHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_404011.AlriunePhase Phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CreatureEffect_Alriune_Petal Effect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitBuf_Alriune_Petal Buf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public AlriuneMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CreatureEffect_Alriune_Curtain Curtain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetBreakDamageReduction(BattleDiceBehavior behavior)
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
	public override bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel GetAttacker()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePetal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemovePetal_Break()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemovePetalAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_404011()
	{
		throw null;
	}

	public enum AlriunePhase
	{
		IDLE,
		ATTACK_PHASE,
		SUPER_PHASE,
		BREAK
	}
}
