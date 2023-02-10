using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MsLocal
{
	public class Value
	{
		[XmlAttribute("locale")]
		public string locale;

		[XmlText]
		public string text;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Value()
		{
			throw null;
		}
	}
}
