using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_butterfly2 : EmotionCardAbilityBase
{
	private const int _strMin = 1;

	private const int _strMax = 2;

	private int Str
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
	public EmotionCardAbility_butterfly2()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Butterfly_DmgByDebuf : BattleUnitBuf
	{
		private const int _dmgAddMin = 2;

		private const int _dmgAddMax = 4;

		private int DmgAdd
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool Hide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetDamageReduction(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeTakeDamage(BattleUnitModel attacker, int dmg)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Butterfly_DmgByDebuf()
		{
			throw null;
		}
	}
}
