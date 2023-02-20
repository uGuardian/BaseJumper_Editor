using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_finalpinocchio_specialAtk : BehaviourActionBase
{
	private const ActionDetail _firstMotion = ActionDetail.S1;

	private const ActionDetail _secondMotion = ActionDetail.S2;

	private bool _bCreatedAtkEffect;

	private float _elapsedWait;

	private GameObject _firstEffect;

	private GameObject _secondEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveCustom_First(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveCustom_Second(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_finalpinocchio_specialAtk()
	{
		throw null;
	}
}
