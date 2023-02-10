using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BookModelPriority : IComparer<BookModel>, IComparer<int>
{
	private List<BookModelPriority.FactorMethod> FactorList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int InstanceID(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Rarity(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Episode(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Chapter(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BookId(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Compare(BookModel a, BookModel b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Compare(int x, int y)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModelPriority(List<BookModelPriority.FactorMethod> factorList)
	{
		throw null;
	}

	public delegate int FactorMethod(BookModel a, BookModel b);
}
