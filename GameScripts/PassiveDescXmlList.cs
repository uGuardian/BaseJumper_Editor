using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class PassiveDescXmlList : Singleton<PassiveDescXmlList>
{
	private Dictionary<LorId, PassiveDesc> _dictionary;

	private Random random;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(PassiveDescRoot descRoot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(PassiveDescRoot descRoot)
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
	public string GetDesc(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDesc(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveDescXmlList()
	{
		throw null;
	}
}
