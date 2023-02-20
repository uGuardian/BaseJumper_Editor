using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class LibrariansNameXmlList : Singleton<LibrariansNameXmlList>
{
	private Dictionary<int, string> _dictionary;

	private Random random;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(CharactersNameRoot nameRoot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRandomName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRandomNameID()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Count()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LibrariansNameXmlList()
	{
		throw null;
	}
}
