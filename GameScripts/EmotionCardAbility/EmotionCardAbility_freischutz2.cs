using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_freischutz2 : EmotionCardAbilityBase
{
	private List<BattlePlayingCardDataInUnitModel> _seventhBullets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
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
	public override void OnStartBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_freischutz2()
	{
		throw null;
	}

	public class BattleUnitBuf_Freischutz_Emotion_Seventh_Bullet : BattleUnitBuf
	{
		private const int _num = 7;

		private int reserve;

		private int triggered;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Freischutz_Emotion_Seventh_Bullet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnLoseParrying(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDrawParrying(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Add()
		{
			throw null;
		}
	}
}
