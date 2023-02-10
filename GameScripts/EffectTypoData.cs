using System;
using System.Runtime.CompilerServices;

public class EffectTypoData
{
	public EffectTypoCategory category;

	public string Title;

	public string Desc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EffectTypoData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EffectTypoData(EffectTypoCategory category, string desc, string title = "")
	{
		throw null;
	}
}
