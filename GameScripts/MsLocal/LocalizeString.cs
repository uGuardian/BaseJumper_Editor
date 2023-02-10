using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MsLocal
{
	public class LocalizeString
	{
		[XmlAttribute("id")]
		public string id;

		[XmlElement("Value")]
		public List<Value> values;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalizeString()
		{
			throw null;
		}
	}
}
