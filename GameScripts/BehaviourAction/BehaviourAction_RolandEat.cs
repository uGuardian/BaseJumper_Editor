using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_RolandEat : BehaviourActionBase
{
	public BattleUnitModel _opponent;

	private Vector3 worldEatPos;

	public Vector3 originOpponentPos;

	private readonly int maxVanilaValue;

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
	public bool EatOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetDefaultOpponent(float deltatime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_RolandEat()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BehaviourAction_RolandEat()
	{
		throw null;
	}
}
