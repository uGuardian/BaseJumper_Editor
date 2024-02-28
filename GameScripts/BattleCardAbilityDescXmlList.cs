using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using LOR_XML;

public class BattleCardAbilityDescXmlList : Singleton<BattleCardAbilityDescXmlList>
{
	private Dictionary<string, BattleCardAbilityDesc> _dictionary;

	private Dictionary<string, List<string>> _dictionaryKeywordCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, BattleCardAbilityDesc> dictionary)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddByMode(string packageId, Dictionary<string, BattleCardAbilityDesc> dict)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityDesc(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAbilityDescString(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDefaultAbilityDescString(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAbilityDesc(DiceBehaviour behaviour)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityDesc(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCardAbilityDesc GetData(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityKeywords(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetAbilityKeywords_byScript(string scriptName)
	{
		throw null;
	}
}
