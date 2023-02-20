using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class EmotionCardAbility_heart_rush : EmotionCardAbilityBase
{
	private const int _maxTurn = 3;

	private const int _str = 4;

	private const int _endur = 4;

	private const int _quick = 4;

	private const int _prot = 4;

	private int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_heart_rush()
	{
		throw null;
	}
}
