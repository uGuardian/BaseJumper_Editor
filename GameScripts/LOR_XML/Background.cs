using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class Background
	{
		[XmlAttribute("Src")]
		public string src;

		[XmlAttribute("Effect")]
		public string effect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Background()
		{
			throw null;
		}
	}
}
