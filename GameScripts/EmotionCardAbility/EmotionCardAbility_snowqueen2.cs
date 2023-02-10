using System;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;

public class EmotionCardAbility_snowqueen2 : EmotionCardAbilityBase
{
	private int cnt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnParryingStart(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWinParrying(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndParrying(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_snowqueen2()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_SnowQueen_Shard : BattleUnitBuf
	{
		private const int _stackMax = 3;

		private BattleUnitModel _attacker;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_SnowQueen_Shard(BattleUnitModel attacker)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_Emotion_SnowQueen_Stun2 : BattleUnitBuf
	{
		private BattleUnitModel _attacker;

		private CreatureEffect _aura;

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_SnowQueen_Stun2(BattleUnitModel attacker)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(BattleUnitModel owner)
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
	}
}
