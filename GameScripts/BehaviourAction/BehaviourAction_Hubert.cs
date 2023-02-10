using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_Hubert : BehaviourActionBase
{
	private Vector3 _selfOriginPos;

	private Vector3 _opponentOriginPos;

	private BattleUnitModel _opponent;

	private LinePatternRenderer _lineRenderer;

	private Vector3 _lineStart;

	private Vector3 _lineEnd;

	private const float chainAttackTime = 0.1f;

	private const float chainPullTime = 0.15f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ChainAttack(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullChain(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AttackDelay(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullOpponent(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionWithCheckWall(BattleUnitModel unit, Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_Hubert()
	{
		throw null;
	}
}
