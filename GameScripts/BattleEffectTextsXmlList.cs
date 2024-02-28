using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BattleEffectTextsXmlList : Singleton<BattleEffectTextsXmlList>
{
	private Dictionary<string, BattleEffectText> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, BattleEffectText> dictionary)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEffectText GetEffectText(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEffectTextName(string id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEffectTextDesc(string id, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEffectTextDesc(string id, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEffectTextDesc(string id)
	{
		throw null;
	}
}
