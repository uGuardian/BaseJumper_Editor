using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_AngelicaCombo : BehaviourActionBase
{
	public static BS3AngelicaCombo angelicaComboPrefab;

	private BattleUnitView _selfView;

	private BattleUnitView _opponentView;

	private bool _done;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsMovable()
	{
		throw null;
	}

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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_AngelicaCombo()
	{
		throw null;
	}
}
