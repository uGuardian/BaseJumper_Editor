using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_silence_emotion_silence : DiceCardSelfAbilityBase
{
	private const int _bind = -5;

	private const float _hpRate = 0.15f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_silence_emotion_silence()
	{
		throw null;
	}
}
