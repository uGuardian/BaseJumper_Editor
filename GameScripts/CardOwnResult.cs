using System;
using System.Runtime.CompilerServices;

public class CardOwnResult
{
	public UnitDataModel unit;

	public LorId cardId;

	public int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardOwnResult()
	{
		throw null;
	}
}
