using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1005531 : PassiveAbilityBase
{
	private const int _special1ID = 9910524;

	private const int _special2ID = 9910525;

	private const int _special3ID = 9910526;

	private Queue<BattleUnitModel> targets;

	private bool recover;

	private bool _init;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveBuf(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDeadEvent(BattleUnitView view)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1005531()
	{
		throw null;
	}

	public class BattleDiceCardBuf_KeterFianl_SilenceGirl_CostUp : BattleDiceCardBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_KeterFianl_SilenceGirl_CostUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattleUnitModel owner, BattlePlayingCardDataInUnitModel playingCard)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDiscard(BattleUnitModel owner, BattleDiceCardModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}
	}
}
