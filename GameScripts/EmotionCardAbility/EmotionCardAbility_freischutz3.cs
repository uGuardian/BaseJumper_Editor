using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class EmotionCardAbility_freischutz3 : EmotionCardAbilityBase
{
	private string _PREFAB_PATH;

	private bool _effect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart_ignoreDead()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_freischutz3()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Fruischutz_Flame : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Fruischutz_Flame()
		{
			throw null;
		}
	}
}
