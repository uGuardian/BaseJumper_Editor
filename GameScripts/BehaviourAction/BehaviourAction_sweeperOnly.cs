using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_sweeperOnly : BehaviourActionBase
{
	private static int _motionCount;

	public static bool movable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsMovable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_sweeperOnly()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BehaviourAction_sweeperOnly()
	{
		throw null;
	}
}
