using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_latitia1 : EmotionCardAbilityBase
{
	private BattleUnitModel _target;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnParryingStart(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDieOtherUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_latitia1()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Latitia_Gift : BattleUnitBuf
	{
		private const float _prob = 0.4f;

		private const int _dmgMin = 2;

		private const int _dmgMax = 7;

		private const int _bleedMin = 2;

		private const int _bleedMax = 2;

		private BattleUnitModel _giver;

		private static bool Prob
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static int Dmg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private static int Bleed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Latitia_Gift(BattleUnitModel giver)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
		{
			throw null;
		}
	}
}
