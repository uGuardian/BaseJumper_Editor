using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class Filter
	{
		[XmlAttribute("Src")]
		public string src;

		[XmlAttribute("Effect")]
		public string effect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Filter()
		{
			throw null;
		}
	}
}
