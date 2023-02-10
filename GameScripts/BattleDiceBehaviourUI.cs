using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleDiceBehaviourUI
{
	public DiceBehaviour behaviourInCard;

	public BattleDiceCardModel cardmodel;

	public bool isDestroyed;

	public DiceUITiming destroyedTiming;

	public bool isSkip;

	public DiceUITiming skipTiming;

	private int _index;

	public bool isRemoveInList;

	public bool isWinAgainstFarAtk;

	public DiceUITiming addedTimingWinAgainstFarAtk;

	public int Index
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehaviourUI(BattleDiceBehavior be)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehaviourUI(BattleDiceBehaviourUI be)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Copy(BattleDiceBehaviourUI b)
	{
		throw null;
	}
}
