using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_260003 : PassiveAbilityBase
{
	private List<PassiveAbility_260003.DmgInfo> _dmgInfos;

	private List<PassiveAbility_260003.DmgInfo> _breakdmgInfos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_260003()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int breakdmg)
	{
		throw null;
	}

	public class BattleUnitBuf_resists : BattleUnitBuf
	{
		public BehaviourDetail hpTarget;

		public BehaviourDetail bpTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_resists()
		{
			throw null;
		}
	}

	public class DmgInfo
	{
		public BehaviourDetail type;

		public int dmg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DmgInfo()
		{
			throw null;
		}
	}
}
