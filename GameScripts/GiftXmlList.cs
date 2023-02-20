using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GiftXmlList : Singleton<GiftXmlList>
{
	private List<GiftXmlInfo> _list;

	private Dictionary<int, GiftXmlInfo> _giftDict;

	private int _nextInstanceId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<GiftXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftXmlInfo GetData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPrefix(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPostfix(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftXmlInfo CreateTemporaryGift(string res, GiftPosition pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftXmlInfo> GetAvailableList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftXmlList()
	{
		throw null;
	}
}
