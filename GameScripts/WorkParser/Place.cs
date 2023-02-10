using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class Place
	{
		[XmlElement("PlaceName")]
		public string placeName;

		[XmlElement("Dialog")]
		public List<Dialog> dialogs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Place()
		{
			throw null;
		}
	}
}
