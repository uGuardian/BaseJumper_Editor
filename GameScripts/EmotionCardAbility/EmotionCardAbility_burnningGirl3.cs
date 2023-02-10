using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_burnningGirl3 : EmotionCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_burnningGirl3()
	{
		throw null;
	}

	public class BattleUnitBuf_burningGirl_Ember_New : BattleUnitBuf
	{
		private const float _prob = 0.25f;

		private const int _triggerStack = 4;

		private bool _triggered;

		private int _max;

		private List<LorId> _targetIDs;

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
		public BattleUnitBuf_burningGirl_Ember_New()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AfterDiceAction(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRollDiceInRecounter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckCondition(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsFirstDice(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<LorId> TargetIDs()
		{
			throw null;
		}
	}

	public class BattleDiceCardBuf_Emotion_BurningGirl : BattleDiceCardBuf
	{
		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_Emotion_BurningGirl()
		{
			throw null;
		}
	}
}
