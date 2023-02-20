using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class QuestXmlList : Singleton<QuestXmlList>
{
	private List<QuestXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<QuestXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestXmlInfo GetData(SephirahType sephirah, int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestXmlList()
	{
		throw null;
	}
}
