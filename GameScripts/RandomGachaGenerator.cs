using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public static class RandomGachaGenerator
{
	public const float probEquip = 0.3f;

	public const float probCommon = 0.4f;

	public const float probUncommon = 0.3f;

	public const float probRare = 0.2f;

	public const float probUnique = 0.1f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DiceCardXmlInfo SelectRandomCard(List<DiceCardXmlInfo> cardList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BookDropItemInfo SelectRandomItem(DropBookXmlInfo book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RestructureProb(List<RandomGachaGenerator.ProbInfo> probInfoList)
	{
		throw null;
	}

	public class ProbInfo
	{
		public List<DropBoxCount> dropList;

		public DropItemType type;

		public float prob;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProbInfo()
		{
			throw null;
		}
	}
}
