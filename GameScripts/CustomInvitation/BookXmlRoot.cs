using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BookXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Book")]
		public List<BookXmlInfo> bookXmlList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlRoot()
		{
			throw null;
		}
	}
}
