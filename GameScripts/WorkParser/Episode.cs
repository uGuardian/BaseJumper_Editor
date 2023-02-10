using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class Episode
	{
		[XmlElement("EpisodeName")]
		public string episodeName;

		[XmlElement("Place")]
		public List<Place> places;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Episode()
		{
			throw null;
		}
	}
}
