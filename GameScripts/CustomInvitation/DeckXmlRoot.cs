using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class DeckXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Deck")]
		public List<DeckXmlInfo> deckXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckXmlRoot()
		{
			throw null;
		}
	}
}
