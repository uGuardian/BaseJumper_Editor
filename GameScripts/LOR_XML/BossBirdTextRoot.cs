using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BossBirdTextRoot
	{
		[XmlElement("param")]
		public List<BossBirdText> textList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BossBirdTextRoot()
		{
			throw null;
		}
	}
}
