using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_Greta_HammerThrow : BehaviourActionBase
{
	private Vector3 _selfOriginPos;

	private Vector3 _opponentOriginPos;

	private BattleUnitModel _opponent;

	private HammerController _hammer;

	private const float chainAttackTime = 0.3f;

	private const float boxingTime = 1f;

	private const float chainPullTime = 0.2f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ChainAttack(float deltaTime, float elapsedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Boxing(float deltaTime, float elapsedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullChain(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullOpponent(float deltaTime, float elapsedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionWithCheckWall(Vector3 pos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_Greta_HammerThrow()
	{
		throw null;
	}
}
