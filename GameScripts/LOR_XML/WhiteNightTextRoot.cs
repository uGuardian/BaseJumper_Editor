using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class WhiteNightTextRoot
	{
		[XmlElement("param")]
		public List<WhiteNightText> textList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhiteNightTextRoot()
		{
			throw null;
		}
	}
}
