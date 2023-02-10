using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1005521 : PassiveAbilityBase
{
	private Queue<BattleUnitModel> targets;

	private bool _init;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
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
	public PassiveAbility_1005521()
	{
		throw null;
	}

	public class BattleDiceCardBuf_KeterFianl_SilenceGirl_CostDown : BattleDiceCardBuf
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
		public BattleDiceCardBuf_KeterFianl_SilenceGirl_CostDown()
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
