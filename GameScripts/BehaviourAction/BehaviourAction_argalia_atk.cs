using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_argalia_atk : BehaviourActionBase
{
	private BattleUnitModel _opponent;

	private BadaAtkBehaviourAction _prefab;

	private float _yOffset;

	private float _elapsedMovUpSelf;

	private Vector3 teleportSrc;

	private Vector3 teleportDst;

	private float _elapsedDownAtk;

	private float _elapsedAirborne;

	private Vector3 originPos;

	private float _elapsedMoveUpOpponent;

	private Vector3 airborneSrc;

	private Vector3 airborneDst;

	private float _elapsedKnockdown;

	private Vector3 knockdownSrc;

	private Vector3 knockdownDst;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveUpSelf(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DownAttackSelf(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AirbornedOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveUpOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool KnockdownOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_argalia_atk()
	{
		throw null;
	}
}
