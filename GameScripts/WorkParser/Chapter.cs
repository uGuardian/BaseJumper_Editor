using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class Chapter
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlElement("Title")]
		public string title;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Chapter()
		{
			throw null;
		}
	}
}
