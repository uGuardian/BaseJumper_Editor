using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class CardDropTableXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("DropTable")]
		public List<CardDropTableXmlInfo> dropTableXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardDropTableXmlRoot()
		{
			throw null;
		}
	}
}
