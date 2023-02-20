using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_605221 : PassiveAbilityBase
{
	private const int _STEALTH_CARD_ID = 9906214;

	private const int _AREAATK_CARD_ID = 9906216;

	private const int _SPECIALATK_CARD_ID = 9906215;

	private bool _bStealth;

	private float _stdHp;

	private float _dmgTaken;

	private int _stealthRound;

	private int _specialAtkCooldown;

	private const float _RATIO = 0.25f;

	private BattleUnitModel _stealthTarget;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsTargetable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpec()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBpResistWeak(bool weak)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDoneStealthFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_605221()
	{
		throw null;
	}
}
