using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class DiceCardXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Card")]
		public List<DiceCardXmlInfo> cardXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlRoot()
		{
			throw null;
		}
	}
}
