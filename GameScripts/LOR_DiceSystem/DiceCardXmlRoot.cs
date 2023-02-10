using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceCardXmlRoot
	{
		[XmlElement("Card")]
		public List<DiceCardXmlInfo> cardXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlRoot()
		{
			throw null;
		}
	}
}
