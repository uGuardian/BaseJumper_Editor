using System;
using System.Collections;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_170301 : PassiveAbilityBase
{
	private const int _hammerID = 702301;

	private const int _maceID = 702302;

	private const int _daggerID = 702303;

	private const int _gauntletID = 702304;

	private const int _lanceID = 702305;

	private const int _attitudeID = 702306;

	private const int _dualbladeID = 702307;

	private const int _bfswordID = 702308;

	private const int _shotgunID = 702309;

	private const int _durandalstrongID = 702310;

	private const int _durandalID = 702311;

	private const int _durandalweakID = 702312;

	private const int _areaID = 702313;

	private const int _atkID = 702315;

	private const int _standbyID = 702316;

	private const int _childID_weapon1 = 60108;

	private const int _childID_weapon2 = 60118;

	private const int _childID_weapon3 = 60128;

	private const int _childID_weapon4 = 60138;

	private const int _childID_weapon5 = 60148;

	private const int _childID_weapon6 = 60158;

	private const int _childID_weapon7 = 60168;

	private const int _childID_weapon8 = 60178;

	private const int _childID_weapon9 = 60188;

	private const int _childID_afterImage1 = 60208;

	private const int _childID_afterImage2 = 60218;

	private const int _childID_afterImage3 = 60228;

	private const int _childID_afterImage4 = 60238;

	private const int _patternCntMax = 5;

	private const float _hpRate_nodmg = 0.4f;

	private int _cardCount;

	private int _patternCount;

	private int _strCnt;

	private BehaviourDetail _currentBuf;

	private BlackSilence4thMapManager _map;

	private bool _transformed;

	private int _dmgReduction;

	private BlackSilence4thMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnLoseHp(int dmg)
	{
		throw null;
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
	public override void OnRoundEndTheLast()
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
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetAddedDiceCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MapReset()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator Transformation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_170301()
	{
		throw null;
	}
}
