using System;
using System.Runtime.CompilerServices;

public class DiceStatBonus
{
	public int dmg;

	public int breakDmg;

	public int power;

	public int face;

	public int min;

	public int max;

	public int dmgRate;

	public int breakRate;

	public int guardBreakAdder;

	public int guardBreakMultiplier;

	public bool ignorePower;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceStatBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceStatBonus Copy()
	{
		throw null;
	}
}
