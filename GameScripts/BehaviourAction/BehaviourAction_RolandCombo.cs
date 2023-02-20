using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_RolandCombo : BehaviourActionBase
{
	public static BS3RolandCombo rolandComboPrefab;

	public static BS3RolandCombo_Opponent opponentPrefab;

	private BattleUnitView _selfView;

	private BattleUnitView _opponentView;

	private bool _doneSelf;

	private bool _doneOpponent;

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
	private bool MoveSelfCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveSelfCustom2(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveOpponentCustom(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool MoveOpponentCustom2(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreatePrefab()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateOpponentPrefab()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_RolandCombo()
	{
		throw null;
	}
}
