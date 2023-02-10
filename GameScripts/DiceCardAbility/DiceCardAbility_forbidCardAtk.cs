using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_forbidCardAtk : DiceCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_forbidCardAtk()
	{
		throw null;
	}

	public class BattleUnitBuf_costUp4 : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCardCostAdder(BattleDiceCardModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_costUp4()
		{
			throw null;
		}
	}
}
