using System;
using System.Runtime.CompilerServices;

public class BookCardOwnResult
{
	public BookModel book;

	public int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookCardOwnResult()
	{
		throw null;
	}
}
