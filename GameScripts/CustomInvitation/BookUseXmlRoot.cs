using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookUseXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("BookUse")]
		public List<DropBookXmlInfo> bookXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookUseXmlRoot()
		{
			throw null;
		}
	}
}
