using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_contractBase : DiceCardSelfAbilityBase
{
	private LorId[] _ids;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool HasContract(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Exchange(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsOnlyAllyUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_contractBase()
	{
		throw null;
	}

	public class BattleUnitBuf_addNextTurnContract : BattleUnitBuf
	{
		private LorId _cardId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_addNextTurnContract(LorId cardId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}
	}
}
