using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_yanDefense : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_yanDefense()
	{
		throw null;
	}

	public class BattleUnitBuf_hp200 : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetMinHp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_hp200()
		{
			throw null;
		}
	}
}
