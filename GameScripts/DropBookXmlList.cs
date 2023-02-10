using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DropBookXmlList : Singleton<DropBookXmlList>
{
	private List<DropBookXmlInfo> _list;

	private Dictionary<LorId, DropBookXmlInfo> _dict;

	private Dictionary<string, List<DropBookXmlInfo>> _workshopDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<DropBookXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDropTable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropBookXmlInfo GetData(int id, bool errNull = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropBookXmlInfo GetData(LorId id, bool errNull = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DropBookXmlInfo> GetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBookByMod(string workshopId, List<DropBookXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDropTableByMod(List<DropBookXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDropTableByMod()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<DropBookXmlInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropBookXmlList()
	{
		throw null;
	}
}
