using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class InventoryFilterOption
{
	public List<ItemType> typeFilter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryFilterOption(params ItemType[] filter)
	{
		throw null;
	}
}
