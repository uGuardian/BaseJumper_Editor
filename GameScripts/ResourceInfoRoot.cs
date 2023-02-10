using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class ResourceInfoRoot
{
	[XmlElement("Info")]
	public List<ResourceXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceInfoRoot()
	{
		throw null;
	}
}
