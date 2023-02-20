using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class FormationXmlList : Singleton<FormationXmlList>
{
	private List<FormationXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<FormationXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationXmlInfo GetData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationXmlList()
	{
		throw null;
	}
}
