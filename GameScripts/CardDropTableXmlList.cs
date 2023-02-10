using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CardDropTableXmlList : Singleton<CardDropTableXmlList>
{
	private List<CardDropTableXmlInfo> _list;

	private Dictionary<string, List<CardDropTableXmlInfo>> _workshopDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<CardDropTableXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardDropTableXmlInfo GetData(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardDropTableByMod(string uniqueId, List<CardDropTableXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<CardDropTableXmlInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CardDropTableXmlInfo> GetWorkshopData(string uniqueId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardDropTableXmlInfo GetWorkshopData(string uniqueId, int bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardDropTableXmlList()
	{
		throw null;
	}
}
