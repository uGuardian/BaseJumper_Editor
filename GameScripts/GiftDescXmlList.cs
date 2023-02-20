using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class GiftDescXmlList : Singleton<GiftDescXmlList>
{
	private Dictionary<string, GiftText> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GiftTextRoot giftRoot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGiftName(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGiftDesc(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGiftPrefix(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGiftPosfix(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGiftAcquireCondition(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftDescXmlList()
	{
		throw null;
	}
}
