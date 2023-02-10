using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class RewardXmlRoot
{
	[XmlElement("Card")]
	public List<FinalRewardCardInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RewardXmlRoot()
	{
		throw null;
	}
}
