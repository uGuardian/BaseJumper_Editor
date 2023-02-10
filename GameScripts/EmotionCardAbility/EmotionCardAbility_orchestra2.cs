using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_orchestra2 : EmotionCardAbilityBase
{
	private const int _maxTurn = 2;

	private int turn;

	private CameraFilterPack_Noise_TV_2 _filter;

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
	public override void OnEndBattlePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_orchestra2()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Orchestra : BattleUnitBuf
	{
		private const int _dmgMin = 2;

		private const int _dmgMax = 4;

		private static int DmgAdd
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
		public override bool TeamKill()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetDamageReduction(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Orchestra()
		{
			throw null;
		}
	}
}
