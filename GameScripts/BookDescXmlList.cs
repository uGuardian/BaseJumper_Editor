using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BookDescXmlList : Singleton<BookDescXmlList>
{
	private Dictionary<int, BookDesc> _dictionaryOrigin;

	private Dictionary<string, List<BookDesc>> _dictionaryWorkshop;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<int, BookDesc> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBookName(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetBookText(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBookTextByMod(string packageId, List<BookDesc> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookDescXmlList()
	{
		throw null;
	}
}
