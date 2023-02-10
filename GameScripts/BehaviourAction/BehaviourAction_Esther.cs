using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_Esther : BehaviourActionBase
{
	private const string _TRAIL_PREFAB_PATH = "Battle/SpecialEffect/ArgaliaSpecialAreaEffect";

	private Vector3 _src;

	private Vector3 _dst;

	private BattleUnitModel _opponent;

	private GameObject _trailObject;

	private static int _count;

	private const float moveTime = 0.05f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsMovable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsOpponentMovable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveForwardWithVariableWithSword(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveForwardWithVariable(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveOpponent(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EarthQuakeRoutine(CameraFilterPack_FX_EarthQuake r)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_Esther()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BehaviourAction_Esther()
	{
		throw null;
	}
}
