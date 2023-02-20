using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_butterfly3 : EmotionCardAbilityBase
{
	private const float _hpRate = 0.5f;

	private const int _cntMax = 2;

	private int cnt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_butterfly3()
	{
		throw null;
	}

	public class BattleUnitBuf_Butterfly_Emotion_Seal : BattleUnitBuf
	{
		private int addedThisTurn;

		private int deleteThisTurn;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Butterfly_Emotion_Seal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int SpeedDiceBreakedAdder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add()
		{
			
		}
	}
}
