using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_TwistedTanyaSpecialAtk : BehaviourActionBase
{
	private BattleUnitModel _opponent;

	private float _airbornDelay;

	private float _knockdownDelay;

	private Vector3 _defaultPos;

	private float _elapsedAirborne;

	private Vector3 _srcAirborne;

	private float _elapsedKnockdown;

	private Vector3 _srcKnockdown;

	private Vector3 _dstKnockdown;

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
	private bool KnockdownOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_TwistedTanyaSpecialAtk()
	{
		throw null;
	}
}
