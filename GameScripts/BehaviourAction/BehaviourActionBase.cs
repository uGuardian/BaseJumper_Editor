using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourActionBase
{
	protected RencounterManager.ActionAfterBehaviour selfAction;

	protected RencounterManager.ActionAfterBehaviour opponentAction;

	protected BattleUnitModel _self;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetAreaAtkRolldiceDelay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetAreaAtkWaitActionDelay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual FarAreaEffect SetFarAreaAtkEffect(BattleUnitModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsMovable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsMovable(BattleCardBehaviourResult self, BattleCardBehaviourResult opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsOpponentMovable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsOpponentMovable(BattleCardBehaviourResult self, BattleCardBehaviourResult opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourActionBase()
	{
		throw null;
	}
}
