using System;
using System.Runtime.CompilerServices;

public class QuestMissionScriptBase_Battle : QuestMissionScriptBase
{
	private string nospoilerID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetDesc(string id, int[] param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool StageEntered()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnClearStage(StageModel stage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestMissionScriptBase_Battle()
	{
		throw null;
	}
}
