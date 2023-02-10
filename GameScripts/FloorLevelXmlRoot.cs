using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FloorLevelXmlRoot
{
	[XmlElement("FloorLevelXmlInfo")]
	public List<FloorLevelXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloorLevelXmlRoot()
	{
		throw null;
	}
}
