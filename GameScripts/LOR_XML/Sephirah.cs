using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class Sephirah
	{
		[XmlAttribute("SephirahType")]
		public SephirahType sephirahType;

		[XmlElement("AbnormalityCard")]
		public List<AbnormalityCard> list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sephirah()
		{
			throw null;
		}
	}
}
