using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class OpeningLyricsRoot
	{
		[XmlElement("Name")]
		public List<OpeningLyrics> lyricsList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpeningLyricsRoot()
		{
			throw null;
		}
	}
}
