using System;
using System.Runtime.CompilerServices;

public class DiceMatch
{
	public static Predicate<DiceMatch> AllDice;

	public static Predicate<DiceMatch> AllAttackDice;

	public static Predicate<DiceMatch> AllDefenseDice;

	public static Predicate<DiceMatch> NextDice;

	public static Predicate<DiceMatch> LastDice;

	public static Predicate<DiceMatch> NextDefenseDice;

	public static Predicate<DiceMatch> NextAttackDice;

	public static Predicate<DiceMatch> NextGuardDice;

	public static Comparison<DiceMatch> MostDiceFace;

	public BattleDiceBehavior abiliity;

	public int index;

	public int indexReverse;

	public int matchCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Predicate<DiceMatch> DiceByIdx(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Predicate<DiceMatch> Random(int num)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceMatch()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DiceMatch()
	{
		throw null;
	}
}
