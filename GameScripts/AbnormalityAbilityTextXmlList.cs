using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class AbnormalityAbilityTextXmlList : Singleton<AbnormalityAbilityTextXmlList>
{
	private Dictionary<string, AbnormalityAbilityText> _dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dictionary<string, AbnormalityAbilityText> dictionary)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAbilityText(string id, int index)
	{
		throw null;
	}
}
