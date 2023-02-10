using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_burnningGirl : EmotionCardAbilityBase
{
	private const float _prob = 0.4f;

	private const int _burnMin = 1;

	private const int _burnMax = 3;

	private bool trigger;

	private static bool Prob
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int Burn
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
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_burnningGirl()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_BurningGirl_Burn : BattleUnitBuf
	{
		private const int _burnMin = 1;

		private const int _burnMax = 1;

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

		private static int Burn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_BurningGirl_Burn()
		{
			throw null;
		}
	}
}
