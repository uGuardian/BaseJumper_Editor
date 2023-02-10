using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class DeckXmlRoot
{
	[XmlElement("Deck")]
	public List<DeckXmlInfo> deckXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeckXmlRoot()
	{
		throw null;
	}
}
