using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BossBirdTextXmlList : Singleton<BossBirdTextXmlList>
{
	private Dictionary<int, string> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BossBirdTextRoot textRoot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetText(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BossBirdTextXmlList()
	{
		throw null;
	}
}
