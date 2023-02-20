using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class StageNameXmlList : Singleton<StageNameXmlList>
{
	private Dictionary<int, string> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(CharactersNameRoot nameRoot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(StageClassInfo stageInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageNameXmlList()
	{
		throw null;
	}
}
