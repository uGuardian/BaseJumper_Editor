using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MsLocal
{
	public class Localization
	{
		[XmlElement("LocalizedString")]
		public List<LocalizeString> localizeString;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Localization()
		{
			throw null;
		}
	}
}
