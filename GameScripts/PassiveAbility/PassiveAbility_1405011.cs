using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_1405011 : PassiveAbilityBase
{
	private const int _tanyaID = 1406011;

	private const int _jaeheonID = 1407011;

	private const int _summonAndHideID = 707501;

	private const int _summonID = 707502;

	private const int _attackID = 707503;

	private const int _counterID = 707504;

	private const int _attackStrongID = 707505;

	private const int _comboAttackID = 707506;

	private const int _distractID = 707507;

	private const int _vulnerableID = 707508;

	private const int _climaxID = 707509;

	private const int _breakDmgTeamDie = 50;

	private const int _breakDmgMin = 2;

	private const int _breakDmgMax = 4;

	private const float _hpRate_nodmg = 0.5f;

	private int _cummulatedDmg;

	private int _cardCount;

	private bool _summonhideUsed;

	private bool _summonUsed;

	public float roundstartHp;

	private ReverberationBand_Map2 _map;

	private EnemyTeamStageManager_TwistedReverberationBand_Middle _stage;

	private bool _transformed;

	private int _dmgReduction;

	private int BreakDmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private ReverberationBand_Map2 Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private EnemyTeamStageManager_TwistedReverberationBand_Middle Stage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetDamageReductionAll()
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
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsAlone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsTanyaAlive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsJaeheonAlive()
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
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1405011()
	{
		throw null;
	}
}
