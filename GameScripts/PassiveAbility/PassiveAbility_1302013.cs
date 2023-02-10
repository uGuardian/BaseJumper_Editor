using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1302013 : PassiveAbilityBase
{
	public PassiveAbility_1302013.EileenPhase currentEileenPhase;

	public bool beliverdeath;

	public int[] specialCards;

	private int _dmgReduction;

	public override string debugDesc
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
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePhase(PassiveAbility_1302013.EileenPhase phase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyNegativeBuf(List<BattleUnitBuf> bufList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckChangePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
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
	public override bool IsImmuneBreakDmg(DamageType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBeliever(int count)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1302013()
	{
		throw null;
	}

	public enum EileenPhase
	{
		None = 500,
		First = 350,
		Second = 150,
		Third = 0
	}
}
