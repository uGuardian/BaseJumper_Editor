using System;
using LOR_DiceSystem;

public struct DiceBehaviourResultData
{
	public Result result;

	public ActionType actionType;

	public BehaviourDetail behaviourDetail;

	public ActionDetail actionDetail;

	public ActionDirection actionStartDir;

	public CardRange range;

	public bool skip;

	public bool passingEvasion;

	public bool BreakState;
}
