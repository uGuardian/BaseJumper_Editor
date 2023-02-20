using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_activateNextSpeedRoll : BattleUnitBuf
{
	private Func<int, int> _action;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_activateNextSpeedRoll(Func<int, int> action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRollSpeedDice()
	{
		
	}
}
