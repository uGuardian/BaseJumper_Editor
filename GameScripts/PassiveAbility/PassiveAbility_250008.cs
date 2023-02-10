using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_250008 : PassiveAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_250008()
	{
		throw null;
	}

	public class DiceCardAbility_250008passive : DiceCardAbilityBase
	{
		private PassiveAbility_250008 _passive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardAbility_250008passive(PassiveAbility_250008 p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice()
		{
			throw null;
		}
	}
}
