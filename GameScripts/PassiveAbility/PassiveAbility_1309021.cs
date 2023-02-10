using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PassiveAbility_1309021 : PassiveAbilityBase
{
	private BattleUnitModel _copyUnit;

	private const int _WEAK_ATK_CARD_ID1 = 703921;

	private const int _WEAK_ATK_CARD_ID2 = 703925;

	private const int _WEAK_ATK_CARD_ID3 = 703926;

	private const int _STRONG_ATK_CARD_ID = 703922;

	private const int _REMAIN_ATK_CARD_ID = 703923;

	private const int _STRONG_TEMP_ATK_CARD_ID = 703924;

	private LorId _copiedCardIdByLoseParrying;

	private PassiveAbility_1309021.Pattern _pattern;

	private GameObject _auraEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCopyUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCopiedCardByLoseParrying(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeSpec()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id, int priorityAdder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(LorId id, int priorityAdder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1309021()
	{
		throw null;
	}

	public enum Pattern
	{
		ONE,
		TWO
	}
}
