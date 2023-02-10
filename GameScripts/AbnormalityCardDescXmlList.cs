using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class AbnormalityCardDescXmlList : Singleton<AbnormalityCardDescXmlList>
{
	private Dictionary<string, AbnormalityCard> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, AbnormalityCard> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbnormalityCard GetAbnormalityCard(string cardID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<AbnormalityCardDialog> GetAbnormalityDialogue(string cardID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbnormalityCardDescXmlList()
	{
		throw null;
	}
}
