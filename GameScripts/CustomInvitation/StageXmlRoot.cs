using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class StageXmlRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Stage")]
		public List<StageClassInfo> list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageXmlRoot()
		{
			throw null;
		}
	}
}
