using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_smallbird_ego : BehaviourActionBase
{
	private const float _preDelay = 0.3f;

	private const float _postDelay = 0.5f;

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
	public BehaviourAction_smallbird_ego()
	{
		throw null;
	}
}
