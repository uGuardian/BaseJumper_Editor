using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GiftGainCondition
{
	[XmlElement("ConditionType")]
	public GiftGainConditionType ConditionType;

	[XmlElement("NemeralType")]
	public GiftConditionNumeralType MinMax;

	[XmlElement("Faction")]
	public GiftConditionCheckFaction Faction;

	[XmlElement("Param")]
	public string Param;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftGainCondition()
	{
		throw null;
	}
}
