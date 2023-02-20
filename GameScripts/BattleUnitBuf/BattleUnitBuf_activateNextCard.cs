using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_activateNextCard : BattleUnitBuf
{
	public BattleUnitBuf_activateNextCard.DequeueAction action;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_activateNextCard(BattleUnitBuf_activateNextCard.DequeueAction action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	public delegate void DequeueAction();
}
