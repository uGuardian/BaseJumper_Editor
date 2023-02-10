using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GiftGainConditionRoot
{
	[XmlElement("Prob")]
	public float Prob;

	[XmlElement("Condition")]
	public List<GiftGainCondition> Conditions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftGainConditionRoot()
	{
		throw null;
	}
}
