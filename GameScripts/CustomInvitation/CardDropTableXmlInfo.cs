using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class CardDropTableXmlInfo
	{
		[XmlAttribute("ID")]
		public int id;

		[XmlElement("Card")]
		public List<CustomIdXml> cardIdList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardDropTableXmlInfo()
		{
			throw null;
		}
	}
}
