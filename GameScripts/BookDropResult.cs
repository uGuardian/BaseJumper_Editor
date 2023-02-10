using System;
using System.Runtime.CompilerServices;

public class BookDropResult
{
	public LorId id;

	public DropItemType itemType;

	public int bookInstanceId;

	public int number;

	public bool hasLimit;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookDropResult()
	{
		throw null;
	}
}
