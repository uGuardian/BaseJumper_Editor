using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BookXmlList : Singleton<BookXmlList>
{
	private List<BookXmlInfo> _list;

	private Dictionary<LorId, BookXmlInfo> _dictionary;

	private Dictionary<string, List<BookXmlInfo>> _workshopBookDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<BookXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookXmlInfo GetData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookXmlInfo GetData(LorId id, bool errNull = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookXmlInfo> GetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEquipPageByMod(string workshopId, List<BookXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<BookXmlInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookXmlList()
	{
		throw null;
	}
}
