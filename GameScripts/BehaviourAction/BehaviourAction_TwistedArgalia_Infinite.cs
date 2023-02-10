using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BehaviourAction_TwistedArgalia_Infinite : BehaviourActionBase
{
	private const int _ROLAND_ID = 1410012;

	private const int _ARGALIA_ID = 1410011;

	private static List<BehaviourAction_TwistedArgalia_Infinite.ActionInfo> _rolandActions;

	private static List<BehaviourAction_TwistedArgalia_Infinite.ActionInfo> _argaliaActions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RencounterManager.MovingAction> SetAction(BehaviourAction_TwistedArgalia_Infinite.ActionInfo r, Type type, ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDefault(List<RencounterManager.MovingAction> actionList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInfo(List<RencounterManager.MovingAction> actionList, BehaviourAction_TwistedArgalia_Infinite.ActionInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitRolandActions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitArgaliaActions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BehaviourAction_TwistedArgalia_Infinite()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BehaviourAction_TwistedArgalia_Infinite()
	{
		throw null;
	}

	public class ActionInfo
	{
		public string effectRes;

		public ActionDetail actionDetail;

		public string actionScript;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActionInfo(string effectRes, ActionDetail actionDetail, string actionScript = null)
		{
			throw null;
		}
	}
}
