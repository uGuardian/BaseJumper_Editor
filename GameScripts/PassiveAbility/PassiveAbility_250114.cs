using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_250114 : PassiveAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_250114()
	{
		throw null;
	}

	public class DiceCardAbility_250114passive : DiceCardAbilityBase
	{
		private PassiveAbility_250114 _passive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardAbility_250114passive(PassiveAbility_250114 p)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice()
		{
			
		}
	}
}
