using System;
using System.Runtime.CompilerServices;

public class BookPassiveInfo
{
	public PassiveXmlInfo passive;

	public bool ischanged;

	public bool isActivated;

	public string name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string desc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookPassiveInfo()
	{
		throw null;
	}
}
