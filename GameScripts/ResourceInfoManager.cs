using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ResourceInfoManager : Singleton<ResourceInfoManager>
{
	private List<ResourceXmlInfo> _list;

	private Dictionary<string, ResourceXmlInfo> _characterResourceTableByName;

	private Dictionary<int, ResourceXmlInfo> _characterResourceTableById;

	private int _nextId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<ResourceXmlInfo> charResourceInfo)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadResourceInfo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ResourceInfoRoot LoadNewResourceInfo(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetId(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsResourceInfo(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceInfoManager()
	{
		throw null;
	}
}
