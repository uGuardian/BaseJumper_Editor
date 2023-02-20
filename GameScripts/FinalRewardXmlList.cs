using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class FinalRewardXmlList : Singleton<FinalRewardXmlList>
{
	private List<FinalRewardCardInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<FinalRewardCardInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<FinalRewardCardInfo> GetFinalRewardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalRewardXmlList()
	{
		throw null;
	}
}
