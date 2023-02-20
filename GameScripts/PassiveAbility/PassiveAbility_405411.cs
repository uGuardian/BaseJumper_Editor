using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_405411 : PassiveAbilityBase
{
	private const int _diceNum = 2;

	private const int _drawNum = 2;

	private const int _bufID = 9904414;

	private const int _superID = 9904415;

	private const int _childID = 9040542;

	private const int _childID2 = 9040543;

	private const int _maxPetal = 3;

	private const float _bRecoverRate = 0.5f;

	private const float _bDmgRate = 0.05f;

	private const int _loseHpMin = 40;

	private const int _loseHpMax = 40;

	private PassiveAbility_405411.AlriunePhase _phase;

	private int _deadCnt;

	private int _petalCnt;

	private bool speedDown;

	private CreatureEffect_Alriune_Petal _effect;

	private BattleUnitBuf_Alriune_Petal _buf;

	private AlriuneMapManager _map;

	private CreatureEffect_Alriune_Curtain _curtain;

	private static int LoseHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PassiveAbility_405411.AlriunePhase Phase
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
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemovePetal_Break()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemovePetalAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_405411()
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
