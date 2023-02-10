using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_burningGirl : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_burningGirl()
	{
		throw null;
	}

	public class BattleUnitBuf_burningGirl_Ember : BattleUnitBuf
	{
		private const float _prob = 0.25f;

		private const int _triggerStack = 4;

		private bool _triggered;

		private int _max;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRollDiceInRecounter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndBattlePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_burningGirl_Ember()
		{
			throw null;
		}
	}
}
