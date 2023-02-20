using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_pinocchio2 : EmotionCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_pinocchio2()
	{
		throw null;
	}

	public class RandomCostBuf : BattleDiceCardBuf
	{
		private int _cost;

		public override DiceCardBufType bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RandomCostBuf()
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
