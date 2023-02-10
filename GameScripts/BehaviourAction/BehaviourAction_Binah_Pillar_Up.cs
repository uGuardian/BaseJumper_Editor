using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_Binah_Pillar_Up : BehaviourActionBase
{
	private BattleUnitModel _opponent;

	private Vector3 _knockbackDir;

	private float _speed;

	private float _distance;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool WaitForPillar(float deltaTime, float elapsedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool OpponentKnockbackMoving(float deltaTime, float elapsedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_Binah_Pillar_Up()
	{
		throw null;
	}
}
