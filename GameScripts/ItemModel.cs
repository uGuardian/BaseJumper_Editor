using System;
using System.Runtime.CompilerServices;

public class ItemModel
{
	public virtual ItemXmlData BaseClassInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ItemType GetItemType()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemModel()
	{
		throw null;
	}
}
