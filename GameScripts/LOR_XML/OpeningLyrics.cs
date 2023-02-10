using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class OpeningLyrics
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlText]
		public string lyrics;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpeningLyrics()
		{
			throw null;
		}
	}
}
