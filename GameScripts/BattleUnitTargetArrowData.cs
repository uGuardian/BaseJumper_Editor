using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;

public class BattleUnitTargetArrowData
{
	public Faction faction;

	public SpeedDiceUI Dice;

	public SpeedDiceUI TargetDice;

	public List<SpeedDiceUI> SubTargetDices;

	public bool isPairing;

	public int heightIdx;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitTargetArrowData()
	{
		throw null;
	}
}
