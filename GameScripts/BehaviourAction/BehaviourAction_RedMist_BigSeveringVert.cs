using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_RedMist_BigSeveringVert : BehaviourActionBase
{
	private BattleUnitModel _opponent;

	private float kaliKnockbackTime;

	private Vector3 _selfOriginPos;

	private Vector3 _direction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> Block(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Knockback(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionWithCheckWall(BattleUnitModel unit, Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_RedMist_BigSeveringVert()
	{
		throw null;
	}
}
