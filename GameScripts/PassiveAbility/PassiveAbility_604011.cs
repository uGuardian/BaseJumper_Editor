using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class PassiveAbility_604011 : PassiveAbilityBase
{
	private const int _summonCardID = 960411;

	private const int _childID = 9060402;

	private const int _specialID = 960414;

	private const int _areaID = 960415;

	private const int _transformedHeight = 350;

	private const int _specialCond = 2;

	private const int _areaCond = 5;

	private const int _coolTimeMaxSp = 2;

	private const int _coolTimeMaxArea = 3;

	private const int _forcelyAreaTurn = 5;

	private const float _transformConddition = 0.5f;

	private const int _secondDeckCardID_1st = 960431;

	private const int _secondDeckCardID_2nd = 960432;

	private const int _secondDeckCardID_3rd = 960433;

	private const int _secondDeckCardNum_1st = 3;

	private const int _secondDeckCardNum_2nd = 3;

	private const int _secondDeckCardNum_3rd = 3;

	private const float _filterTargetBrightness = -0.3f;

	private const float _filterTargetR = 0.7f;

	private const float _filterOnTime = 0.6f;

	private const float _filterKeepTime = 0.45f;

	private const float _filterOffTime = 0.6f;

	private int coolTimeSP;

	private int coolTimeArea;

	private int turnCnt;

	private bool _transformed;

	private bool _areaUsed;

	private bool _summon;

	private NosferatuMapManager _map;

	private BattleUnitBuf_Nosferatu_Blood _buf;

	private int _dmgReduction;

	private NosferatuMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BattleUnitBuf_Nosferatu_Blood Buf
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
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetStrengthByBlood()
	{
		
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
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Transform()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FilterCoroutine(CameraFilterPack_Colors_Adjust_ColorRGB f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_604011()
	{
		throw null;
	}
}
