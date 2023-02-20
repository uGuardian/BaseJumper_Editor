using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class PassiveAbility_243201 : PassiveAbilityBase
{
	private List<PassiveAbility_243201.Info> _vulnerableUnitAtkInfo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetVulnerableStack(BattleUnitModel u)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BehaviourDetail IsVulnerableAtk(PassiveAbility_243201.Info info, int flag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveVulnerableResistBuf(PassiveAbility_243201.Info info, BehaviourDetail hpDetail, BehaviourDetail bpDetail)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_243201()
	{
		throw null;
	}

	public class Info
	{
		public BattleUnitModel target;

		public BattleDiceBehavior lastBehavior;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Info()
		{
			throw null;
		}
	}
}
