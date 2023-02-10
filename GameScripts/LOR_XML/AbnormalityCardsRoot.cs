using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class AbnormalityCardsRoot
	{
		[XmlElement("Sephirah")]
		public List<Sephirah> sephirahList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AbnormalityCardsRoot()
		{
			throw null;
		}
	}
}
