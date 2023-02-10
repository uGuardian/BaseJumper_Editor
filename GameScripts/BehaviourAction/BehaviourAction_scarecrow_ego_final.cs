using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_scarecrow_ego_final : BehaviourActionBase
{
	private Vector3 _selfOriginPos;

	private Vector3 _opponentOriginPos;

	private BattleUnitModel _opponent;

	private ScarecrowArmLinePatterRenderer _lineRenderer;

	private Vector3 _lineStart;

	private Vector3 _lineEnd;

	private const float throwArmTime = 0.15f;

	private const float pullArmTime = 0.125f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ThrowArm(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullArm(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AttackDelay(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PullSelf(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionWithCheckWall(BattleUnitModel unit, Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_scarecrow_ego_final()
	{
		throw null;
	}
}
