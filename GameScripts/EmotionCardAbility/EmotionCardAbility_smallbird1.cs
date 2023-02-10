using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionCardAbility_smallbird1 : EmotionCardAbilityBase
{
	private const int _powMin = 2;

	private const int _powMax = 4;

	private bool dmged;

	private static int Pow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_smallbird1()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_SmallBird_Punish : BattleUnitBuf
	{
		private bool powUp;

		private GameObject aura;

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
		public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDie()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DestroyAura()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_SmallBird_Punish()
		{
			throw null;
		}
	}
}
