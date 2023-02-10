using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_emotion_bless : DiceCardSelfAbilityBase
{
	private const int _heal = 6;

	private const int _endu = 1;

	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValidTarget(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsOnlyAllyUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_emotion_bless()
	{
		throw null;
	}
}
