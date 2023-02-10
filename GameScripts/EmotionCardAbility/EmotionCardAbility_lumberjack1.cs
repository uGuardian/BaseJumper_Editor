using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class EmotionCardAbility_lumberjack1 : EmotionCardAbilityBase
{
	private const int _stack = 3;

	private int pp;

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
	public EmotionCardAbility_lumberjack1()
	{
		throw null;
	}

	public class BattleUnitBuf_Lumberjack_emotion : BattleUnitBuf
	{
		private const int _powMin = 1;

		private const int _powMax = 2;

		private SoundEffectPlayer sound;

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

		private int Pow
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
		public override void Init(BattleUnitModel owner)
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
		public BattleUnitBuf_Lumberjack_emotion()
		{
			throw null;
		}
	}
}
