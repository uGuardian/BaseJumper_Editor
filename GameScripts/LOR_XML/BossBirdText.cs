using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BossBirdText
	{
		[XmlAttribute("index")]
		public int index;

		[XmlText]
		public string text;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BossBirdText()
		{
			throw null;
		}
	}
}
