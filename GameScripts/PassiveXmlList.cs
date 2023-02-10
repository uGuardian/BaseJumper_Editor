using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveXmlList : Singleton<PassiveXmlList>
{
	private List<PassiveXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<PassiveXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveXmlInfo GetData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveXmlInfo GetData(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPassivesByMod(List<PassiveXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PassiveXmlInfo> GetDataAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveXmlList()
	{
		throw null;
	}
}
