using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_longbird_simpan : BehaviourActionBase
{
	private const float _beforeDelay = 1f;

	private const float _filterDelay = 3.5f;

	private const float _afterDmgDelay = 0.5f;

	private const int _stackMax = 5;

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
	public BehaviourAction_longbird_simpan()
	{
		throw null;
	}
}
