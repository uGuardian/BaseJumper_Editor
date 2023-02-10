using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BehaviourAction_longbirdEgo : BehaviourActionBase
{
	private const float _beforeDelay = 1f;

	private const float _filterDelay = 3.5f;

	private const float _beforeDmgDelay = 0.5f;

	private const float _afterDmgDelay = 0.5f;

	private const int _stackMax = 5;

	private const float _effectScaleFactor = 1.5f;

	private const string _startEffect = "Prefabs/Battle/DiceAttackEffects/CreatureBattle/LongBird_Judgement_StartEffect";

	private const string _endEffect = "Prefabs/Battle/DiceAttackEffects/CreatureBattle/LongBird_Judgement_EndEffect";

	private BattleUnitModel _target;

	private GameObject _effect;

	private LongBirdMapManager _map;

	private LongBirdMapManager Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AttackDelay(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AttackPreDelay(float deltaTime, float elapedTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_longbirdEgo()
	{
		throw null;
	}
}
