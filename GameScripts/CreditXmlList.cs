using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CreditXmlList : Singleton<CreditXmlList>
{
	private List<CreditXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<CreditXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CreditXmlInfo> GetCreditList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreditXmlList()
	{
		throw null;
	}
}
