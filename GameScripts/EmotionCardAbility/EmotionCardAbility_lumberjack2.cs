using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_lumberjack2 : EmotionCardAbilityBase
{
	private const int _dmg = 15;

	private const int _targetNum = 2;

	private int accumulatedDmg;

	private bool dmged;

	private bool killed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AfterGiveDamage(BattleUnitModel target, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnKill(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Effect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ability()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_lumberjack2()
	{
		throw null;
	}

	public class BattleDiceCardBuf_Lumberjack_Emotion : BattleDiceCardBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUseCard(BattleUnitModel owner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_Lumberjack_Emotion()
		{
			throw null;
		}
	}

	public class BattleDiceCardBuf_Lumberjack_Emotion_Killed : EmotionCardAbility_lumberjack2.BattleDiceCardBuf_Lumberjack_Emotion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDiceCardBuf_Lumberjack_Emotion_Killed()
		{
			throw null;
		}
	}
}
