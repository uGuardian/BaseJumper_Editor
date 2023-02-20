using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class QuestMissionScriptBase_GetBook : QuestMissionScriptBase
{
	private string nospoilerID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetDesc(string id, int[] param)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual List<int> GetStageIDs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool StageCleared()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGetBook(int bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestMissionScriptBase_GetBook()
	{
		throw null;
	}
}
