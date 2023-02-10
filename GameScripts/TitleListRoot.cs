using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class TitleListRoot
{
	[XmlElement("Title")]
	public List<TitleXmlInfo> List;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleListRoot()
	{
		throw null;
	}
}
