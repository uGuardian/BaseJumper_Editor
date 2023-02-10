using System;
using System.Runtime.CompilerServices;

public class BattleUnitBreakDetail
{
	private BattleUnitModel _self;

	public int breakGauge;

	public int breakLife;

	public bool nextTurnBreak;

	public bool blockRecoverBreakByEvaision;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBreakDetail(BattleUnitModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetGauge()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBreakDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverBreakWithoutEffect(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRecoverBreakByEvaision(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverBreak(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBreakMax()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBreakLifeZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeBreakDamage(int damage, DamageType type = DamageType.Attack, BattleUnitModel attacker = null, AtkResist atkResist = AtkResist.Normal, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseBreakGauge(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverBreakLife(int v, bool ignore = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseBreakLife(BattleUnitModel attacker = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyBreakPoint(BattleUnitModel attacker = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDefaultBreakGauge()
	{
		throw null;
	}
}
