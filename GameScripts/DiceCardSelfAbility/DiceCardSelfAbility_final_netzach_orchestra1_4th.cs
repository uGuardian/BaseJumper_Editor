using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_final_netzach_orchestra1_4th : DiceCardSelfAbilityBase
{
	private List<DiceCardSelfAbility_final_netzach_orchestra1_4th.SuccessAtkInfo> _atkList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAreaAttack(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_final_netzach_orchestra1_4th()
	{
		throw null;
	}

	public class SuccessAtkInfo
	{
		public BattleUnitModel target;

		public int count;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccessAtkInfo()
		{
			throw null;
		}
	}
}
