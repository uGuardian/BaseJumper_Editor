using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_TwistedArgalia_PenetrateArgalia : BehaviourActionBase
{
	public static TwistedArgaliaDeadAction actionObj;

	private BattleUnitView _roland;

	private BattleUnitView _argalia;

	private float _eMoveToBoundary;

	private Vector3 _boundarySrc;

	private Vector3 _boundaryDst;

	private float _eChargeToCenter;

	private Vector3 _chargeSrc;

	private Vector3 _chargeDst;

	private float _eMoveToCenter;

	private Vector3 _centerSrc;

	private Vector3 _centerDst;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePrefab()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveToBoundary(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ChargeToCenter(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveToCenter(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_TwistedArgalia_PenetrateArgalia()
	{
		throw null;
	}
}
