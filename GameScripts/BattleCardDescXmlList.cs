using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BattleCardDescXmlList : Singleton<BattleCardDescXmlList>
{
	private Dictionary<LorId, BattleCardDesc> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<LorId, BattleCardDesc> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCardDesc GetCardDesc(LorId cardID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCardName(LorId cardID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAbilityDesc(LorId cardID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBehaviourDesc(LorId cardID, int behaviourIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCardDescXmlList()
	{
		throw null;
	}
}
