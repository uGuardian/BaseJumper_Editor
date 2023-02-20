using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_latitia2 : EmotionCardAbilityBase
{
	private const int _powMin = 2;

	private const int _powMax = 4;

	private static int Pow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_latitia2()
	{
		throw null;
	}

	public class BattleDiceCardBuf_Emotion_Heart : BattleDiceCardBuf
	{
		private const int _dmgMin = 2;

		private const int _dmgMax = 7;

		private const int _turn = 2;

		private int turn;

		private bool used;

		private static int Dmg
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
		public override void OnUseCard(BattleUnitModel owner)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_Emotion_Heart()
		{
			throw null;
		}
	}
}
