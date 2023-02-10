using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CardDropTableXmlRoot
{
	[XmlElement("DropTable")]
	public List<CardDropTableXmlInfo> dropTableXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardDropTableXmlRoot()
	{
		throw null;
	}
}
