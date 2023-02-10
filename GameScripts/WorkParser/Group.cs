using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class Group
	{
		[XmlElement("GroupName")]
		public string groupName;

		[XmlElement("Episode")]
		public List<Episode> episodes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Group()
		{
			throw null;
		}
	}
}
