using System;
using System.Runtime.CompilerServices;

public class ItemData
{
	public string title;

	public string description;

	public string tag;

	public string contentpath;

	public string preview;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemData()
	{
		throw null;
	}
}
