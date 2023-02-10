using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GiftHistoryInfo
{
	private static GiftHistoryInfo _instance;

	public const int abnormalityUseCondition = 10;

	public const int killReverberationCondition = 1;

	public readonly List<string> abnormalityGiftKeyTable;

	public readonly Dictionary<int, int> egoCardGiftIdTable;

	public static GiftHistoryInfo instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftHistoryInfo()
	{
		throw null;
	}
}
