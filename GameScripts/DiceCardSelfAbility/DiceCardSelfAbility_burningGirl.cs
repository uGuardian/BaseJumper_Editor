using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_burningGirl : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRollDiceInRecounter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEndBattlePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_burningGirl_Ember()
		{
			throw null;
		}
	}
}
