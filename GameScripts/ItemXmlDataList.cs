using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class ItemXmlDataList
{
	private static ItemXmlDataList _instance;

	private List<DiceCardXmlInfo> _cardInfoList;

	private List<DiceCardXmlInfo> _basicCardList;

	private Dictionary<LorId, DiceCardXmlInfo> _cardInfoTable;

	private Dictionary<string, List<DiceCardXmlInfo>> _workshopDict;

	public static ItemXmlDataList instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCardInfo(List<DiceCardXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetCardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetBasicCardList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardXmlInfo GetCardItem(int id, bool errNull = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardXmlInfo GetCardItem(LorId id, bool errNull = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardInfoByMod(string workshopId, List<DiceCardXmlInfo> list)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, List<DiceCardXmlInfo>> GetAllWorkshopData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemXmlDataList()
	{
		throw null;
	}
}
