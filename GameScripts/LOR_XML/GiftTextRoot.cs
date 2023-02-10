using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class GiftTextRoot
	{
		[XmlElement("GiftText")]
		public List<GiftText> giftList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GiftTextRoot()
		{
			throw null;
		}
	}
}
