using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class TitleXmlList : Singleton<TitleXmlList>
{
	private List<TitleXmlInfo> _prefixList;

	private List<TitleXmlInfo> _postfixList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<TitleXmlInfo> prefix, List<TitleXmlInfo> postFix)
	{
		
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
	public string GetFullName(int prefixID, int postfixID, string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<TitleXmlInfo> GetPrefixList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<TitleXmlInfo> GetPostfixList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleXmlList()
	{
		throw null;
	}
}
