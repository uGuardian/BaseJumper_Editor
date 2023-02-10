using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ToolTipXmlList : Singleton<ToolTipXmlList>
{
	private List<ToolTipXmlInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<ToolTipXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolTipXmlInfo GetData(ToolTipTarget id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetToolTip(ToolTipTarget id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolTipXmlList()
	{
		throw null;
	}
}
