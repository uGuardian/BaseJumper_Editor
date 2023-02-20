using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_silence_emotion_haste : DiceCardSelfAbilityBase
{
	private const int _quick = 5;

	private const float _hpRate = 0.1f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseInstance(BattleUnitModel unit, BattleDiceCardModel self, BattleUnitModel targetUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_silence_emotion_haste()
	{
		throw null;
	}
}
