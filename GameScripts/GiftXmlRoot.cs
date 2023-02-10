using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GiftXmlRoot
{
	[XmlElement("Gift")]
	public List<GiftXmlInfo> giftXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftXmlRoot()
	{
		throw null;
	}
}
