using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class BookUseXmlRoot
{
	[XmlElement("BookUse")]
	public List<DropBookXmlInfo> bookXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookUseXmlRoot()
	{
		throw null;
	}
}
