using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class ScenarioRoot
	{
		[XmlElement("Chapter")]
		public Chapter chapter;

		[XmlElement("Group")]
		public List<Group> groups;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ScenarioRoot()
		{
			throw null;
		}
	}
}
