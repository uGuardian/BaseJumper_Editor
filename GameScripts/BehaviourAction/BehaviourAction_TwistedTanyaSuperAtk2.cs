using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_TwistedTanyaSuperAtk2 : BehaviourActionBase
{
	private BattleUnitModel _opponent;

	private float _airbornDelay;

	private float _knockbackDelay;

	private Vector3 _defaultPos;

	private float _elapsedAirborne;

	private Vector3 _srcAirborne;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AirbornedOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool KnockbackOpponent(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_TwistedTanyaSuperAtk2()
	{
		throw null;
	}
}
